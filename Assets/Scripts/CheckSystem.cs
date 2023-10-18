using UnityEngine;

public class CheckSystem : MonoBehaviour
{
    void Start()
    {
        string gpuName = SystemInfo.graphicsDeviceName;
        DataToDBDTO.GraphicsCard = gpuName;
        string processorName = SystemInfo.processorType;
        int countOfProcessors = SystemInfo.processorCount;
        float memorySize = Mathf.Round((SystemInfo.systemMemorySize / 1024f) * 100f) / 100f; 
        bool isInternetConnected = Application.internetReachability != NetworkReachability.NotReachable;
        if (isInternetConnected)
        {
            NetworkReachability reachability = Application.internetReachability;
            Debug.Log(reachability);
        }
        Debug.Log(gpuName);
        Debug.Log(processorName);
        Debug.Log(countOfProcessors);
        Debug.Log(memorySize);
    }
}
