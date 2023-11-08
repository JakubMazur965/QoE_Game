using System;
using System.Collections;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using UnityEngine;
using UnityEngine.Networking;
using Debug = UnityEngine.Debug;

public class CheckSystem : MonoBehaviour
{
    private string _url = "https://api.fast.com/netflix/speedtest/v2?https=true&token=YXNkZmFzZGxmbnNkYWZoYXNkZmhrYWxm&urlCount=5";
    private Stopwatch _stopwatch;
    void Start()
    {
        DataToDbdto.GraphicsCard = SystemInfo.graphicsDeviceName;
        DataToDbdto.Processor = SystemInfo.processorType;
        DataToDbdto.ProcessorCores = SystemInfo.processorCount;
        DataToDbdto.MemorySize = Mathf.Round((SystemInfo.systemMemorySize / 1024f) * 100f) / 100f; 
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            DataToDbdto.InternetConnectionType = Application.internetReachability.ToString();
            StartCoroutine(MeasureSpeed());
            PingServer();
        }
    }
    
    IEnumerator MeasureSpeed()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(_url))
        {
            _stopwatch = new Stopwatch();

            _stopwatch.Start();
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.LogError("Error: " + www.error);
            }
            else
            {
                _stopwatch.Stop();
                long fileSize = (long) www.downloadedBytes;
                float downloadTime = (float) _stopwatch.Elapsed.TotalSeconds;
                float downloadSpeedMbps = fileSize / downloadTime / 8;
                DataToDbdto.InternetSpeed = downloadSpeedMbps;
            }
        }
    }
    
    private void PingServer()
    {
        string server = "mysql.agh.edu.pl";
        int port = 3306;
        string username = "jakubma1";
        string password = "x99YAgt20iYtAP8z";
        string database = "jakubma1";
        string connectionString = $"Server={server};Port={port};Database={database};User Id={username};Password={password}";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                DateTime startTime = DateTime.Now;
                connection.Open();
                DateTime endTime = DateTime.Now;
                TimeSpan pingTime = endTime - startTime;
                DataToDbdto.InternetDelay = (float) pingTime.TotalMilliseconds;
            }
            catch (Exception ex)
            {
                Debug.LogError("Ping failed: " + ex.Message);
            }
        }
    }
    
}