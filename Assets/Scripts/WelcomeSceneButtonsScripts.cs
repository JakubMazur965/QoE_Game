using UnityEngine;

public class WelcomeSceneButtonsScripts : MonoBehaviour
{
    [SerializeField] private GameObject creditsPanel;
    
    public void PlayGame()
    {
        // SceneManager.LoadScene("GameScene");
        Debug.Log("Start");
    }
    
    public void UpdateCreditsPanel()
    {
        creditsPanel.SetActive(true);
    }
    
    public void ExitCreditsPanel()
    {
        creditsPanel.SetActive(false);
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}
