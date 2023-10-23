using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionSceneButtonsHelperScript : MonoBehaviour
{
    public void LetsStart()
    {
        SceneManager.LoadScene("UserDataScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
