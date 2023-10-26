using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticalPartEngine : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("ResponseTimeScene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
