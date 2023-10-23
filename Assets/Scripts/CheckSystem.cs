using UnityEngine;

public class CheckSystem : MonoBehaviour
{
    void Start()
    {
        DataToDbdto.GraphicsCard = SystemInfo.graphicsDeviceName;
        DataToDbdto.Processor = SystemInfo.processorType;
        DataToDbdto.ProcessorCores = SystemInfo.processorCount;
        DataToDbdto.MemorySize = Mathf.Round((SystemInfo.systemMemorySize / 1024f) * 100f) / 100f; 
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            DataToDbdto.InternetConnectionType = Application.internetReachability.ToString();
        }
    }
}
