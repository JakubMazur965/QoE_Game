using System;
using MySql.Data.MySqlClient;
using UnityEngine;

public class DBHelper : MonoBehaviour
{
    private static string _connectionString;
    
    public static void SaveAllDataToDB()
    {
        string server = "mysql.agh.edu.pl";
        int port = 3306;
        string username = "jakubma1";
        string password = "x99YAgt20iYtAP8z";
        string database = "jakubma1";
        
        // Connection to DataBase
        _connectionString = $"Server={server};Port={port};Database={database};User Id={username};Password={password}";

        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
        
            string insertQuery = "INSERT INTO Data (name, surname, age, gender, game_device, game_experience, game_frequency, " +
                                 "glasses, processor, processor_cores, graphics_card, memory_size, " +
                                 "internet_connection_type, internet_speed, internet_delay, lvl_response_avg_time," +
                                 "lvl_response_mos, lvl_memorizing_result, lvl_memorizing_mos, lvl_aim_time," +
                                 "lvl_aim_mos, lvl_puzzle_time, lvl_puzzle_mos, system_recommendation, " +
                                 "system_recommendation_all_data, system_recommendation_mos, whole_game_mos) " +
                                 "VALUES (@name, @surname, @age, @gender, @gameDevice, @gameExperience, @gameFrequency," +
                                 "@glasses, @processor, @processorCores, @gpu, @memorySize, @intConType, @intSpeed," +
                                 "@intDelay, @lvlResponseAvgTime, @lvlResponseMos, @lvlMemRes, @lvlMemMos, @lvlAimTime," +
                                 "@lvlAimMos, @lvlPuzzleTime, @lvlPuzzleMos, @sysRec, @sysRecAllData, @sysRecMos," +
                                 "@wholeGameMos)";
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@name", DataToDbdto.Name);
            cmd.Parameters.AddWithValue("@surname", DataToDbdto.Surname);
            cmd.Parameters.AddWithValue("@age", DataToDbdto.Age);
            cmd.Parameters.AddWithValue("@gender", DataToDbdto.Gender);
            cmd.Parameters.AddWithValue("@gameDevice", DataToDbdto.GameDevice);
            cmd.Parameters.AddWithValue("@gameExperience", DataToDbdto.GameExperience);
            cmd.Parameters.AddWithValue("@gameFrequency", DataToDbdto.GameFrequency);
            cmd.Parameters.AddWithValue("@glasses", DataToDbdto.Glasses);
            cmd.Parameters.AddWithValue("@processor", DataToDbdto.Processor);
            cmd.Parameters.AddWithValue("@processorCores", DataToDbdto.ProcessorCores);
            cmd.Parameters.AddWithValue("@gpu", DataToDbdto.GraphicsCard);
            cmd.Parameters.AddWithValue("@memorySize", DataToDbdto.MemorySize);
            cmd.Parameters.AddWithValue("@intConType", DataToDbdto.InternetConnectionType);
            cmd.Parameters.AddWithValue("@intSpeed", DataToDbdto.InternetSpeed);
            cmd.Parameters.AddWithValue("@intDelay", DataToDbdto.InternetDelay);
            cmd.Parameters.AddWithValue("@lvlResponseAvgTime", DataToDbdto.LvlResponseAvgTime);
            cmd.Parameters.AddWithValue("@lvlResponseMos", DataToDbdto.LvlResponseMos);
            cmd.Parameters.AddWithValue("@lvlMemRes", DataToDbdto.LvlMemorizingResult);
            cmd.Parameters.AddWithValue("@lvlMemMos", DataToDbdto.LvlMemorizingMos);
            cmd.Parameters.AddWithValue("@lvlAimTime", DataToDbdto.LvlAimTime);
            cmd.Parameters.AddWithValue("@lvlAimMos", DataToDbdto.LvlAimMos);
            cmd.Parameters.AddWithValue("@lvlPuzzleTime", DataToDbdto.LvlPuzzleTime);
            cmd.Parameters.AddWithValue("@lvlPuzzleMos", DataToDbdto.LvlPuzzleMos);
            cmd.Parameters.AddWithValue("@sysRec", DataToDbdto.SystemRecommendation);
            cmd.Parameters.AddWithValue("@sysRecAllData", DataToDbdto.SystemRecommendationAllData);
            cmd.Parameters.AddWithValue("@sysRecMos", DataToDbdto.SystemRecommendationMos);
            cmd.Parameters.AddWithValue("@wholeGameMos", DataToDbdto.WholeGameMos);
        
            try
            {
                cmd.ExecuteNonQuery();
                Debug.Log("Dodano rekord do tabeli Data.");
            }
            catch (Exception e)
            {
                Debug.LogError("Błąd podczas dodawania rekordu: " + e.Message);
            }
        }
    }
}
