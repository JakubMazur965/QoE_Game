using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeSceneButtonsScripts : MonoBehaviour
{
    [SerializeField] private GameObject creditsPanel;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("IntroductionScene");
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
