using TMPro;
using UnityEngine;

public class MemorizingLevelEngine : MonoBehaviour
{
    [SerializeField] private GameObject descriptionTextGameObjet;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonExit;
    
    void Start()
    {
        descriptionTextGameObjet.SetActive(true);
        buttonStart.SetActive(true);
        buttonExit.SetActive(true);
    }
    
    public void StartGame()
    {
        descriptionTextGameObjet.SetActive(false);
        buttonStart.SetActive(false);
        buttonExit.SetActive(false);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
