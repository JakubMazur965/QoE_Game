using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResponseTimeEngine : MonoBehaviour
{
    [SerializeField] private GameObject titleTextGameObjet;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonExit;
    [SerializeField] private GameObject responseTimeButton;
    [SerializeField] private GameObject responseTimeTextGameObject;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private TMP_Text responseTimeText;
    
    private string _additionText;
    private string _responseTimeTextCore;
    private bool _isButtonGreen;
    private float _startTime;
    private int _trials;
    private float _totalReactionTime;

    void Start()
    {
        _isButtonGreen = false;
        _trials = 3;
        _totalReactionTime = 0f;
        _responseTimeTextCore = responseTimeText.text;
        
        titleTextGameObjet.SetActive(true);
        buttonStart.SetActive(true);
        buttonExit.SetActive(true);
        responseTimeButton.SetActive(false);
        responseTimeTextGameObject.SetActive(false);
        nextButton.SetActive(false);
    }

    public void StartGame()
    {
        titleTextGameObjet.SetActive(false);
        buttonStart.SetActive(false);
        buttonExit.SetActive(false);
        responseTimeButton.SetActive(true);
        responseTimeTextGameObject.SetActive(true);
        
        StartCoroutine(Game());
    }

    private IEnumerator Game()
    {
        // time between trials
        yield return new WaitForSeconds(Random.Range(2f, 3f));
        
        // preparing before new trial
        responseTimeButton.GetComponent<Image>().color = new Color(220 / 255f, 0 / 255f, 0 / 255f);
        
        // wait for green button
        yield return new WaitForSeconds(Random.Range(5f, 10f));
        responseTimeButton.GetComponent<Image>().color = new Color(0 / 255f, 220 / 255f, 0 / 255f);
        _isButtonGreen = true;
        
        // time measurement - start
        _startTime = Time.time;
    }

    public void greenButtonOnClick()
    {
        if (_isButtonGreen)
        {
            // end trial
            _isButtonGreen = false;
            
            // time measurement - end
            float reactionTime = Time.time - _startTime;
            _totalReactionTime += reactionTime;
            _trials--;

            // new trial
            if (_trials > 0)
            {
                _additionText = reactionTime.ToString("F2") + " s\n Remaining  attempts: " + _trials;
                responseTimeText.text = _responseTimeTextCore + " " + _additionText;
                StartCoroutine(Game());
            }
            // end game
            else
            {
                float averageReactionTime = _totalReactionTime / 3;
                DataToDbdto.LvlResponseAvgTime = averageReactionTime;

                switch (averageReactionTime)
                {
                    case >= 0.1f and < 0.25f:
                        GamesCategoryPointsHelper.AddPoints(2,3,3,5,2,5,3,2,3);
                        break;
                    case >= 0.25f and < 0.35f:
                        GamesCategoryPointsHelper.AddPoints(1,1,1,2,1,2,1,1,2);
                        break;
                    case >= 0.35f and < 0.45f:
                        GamesCategoryPointsHelper.AddPoints(0,0,0,0,0,0,0,0,1);
                        break;
                    case >= 0.45f and < 0.55f:
                        GamesCategoryPointsHelper.AddPoints(-1,-1,-1,-2,-1,-2,-1,-1,0);
                        break;
                    case >= 0.55f or < 0.1f:
                        GamesCategoryPointsHelper.AddPoints(-2,-3,-3,-5,-2,-5,-3,-2,-1);
                        break;
                }
                
                titleText.text = "Average response time: " + averageReactionTime.ToString("F2") + " [s]";
                titleTextGameObjet.SetActive(true);
                nextButton.SetActive(true);
                buttonExit.SetActive(true);
                responseTimeButton.SetActive(false);
                responseTimeTextGameObject.SetActive(false);
            }
        }
    }
    
    public void Next()
    {
        SceneManager.LoadScene("ResponseTimeMOS");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
