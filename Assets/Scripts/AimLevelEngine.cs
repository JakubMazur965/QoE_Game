using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AimLevelEngine : MonoBehaviour
{
    [SerializeField] private GameObject buttonExit;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject textDescriptionGameObject;
    [SerializeField] private TMP_Text textDescription;
    [SerializeField] private GameObject pointPreFab;
    [SerializeField] private GameObject timeTextGameObject;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private GameObject scoreTextGameObject;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject nextButton;

    public static int PointsShot;
    
    private int _pointsToSpawn;
    private float _timeBetweenSpawns;
    private float _timer;
    private Coroutine _timerCoroutine;
    private Coroutine _scoreCoroutine;
    
    void Start()
    {
        buttonExit.SetActive(true);
        buttonStart.SetActive(true);
        textDescriptionGameObject.SetActive(true);
        timeTextGameObject.SetActive(false);
        scoreTextGameObject.SetActive(false);
        nextButton.SetActive(false);

        PointsShot = 0;
        _pointsToSpawn = 50;
        _timer = 0f;
    }
    
    private IEnumerator StartTimer()
    {
        while (true)
        {
            scoreText.text = "Score: " + PointsShot;
            yield return null; 
        }
    }
    
    private IEnumerator StartScore()
    {
        while (true)
        {
            _timer += Time.deltaTime;
            timeText.text = _timer.ToString("F1") + " [s]"; 
            yield return null; 
            
            if (PointsShot == 50)
            {
                StopCoroutine(_timerCoroutine);
                StopCoroutine(_scoreCoroutine);
                EndLevel();
            }
        }
    }

    public void ButtonStartOnClick()
    {
        buttonExit.SetActive(false);
        buttonStart.SetActive(false);
        textDescriptionGameObject.SetActive(false);
        timeTextGameObject.SetActive(true);
        scoreTextGameObject.SetActive(true);

        StartCoroutine(GeneratePointsCoroutine());
        _timerCoroutine = StartCoroutine(StartTimer());
        _scoreCoroutine = StartCoroutine(StartScore());
    }

    private IEnumerator GeneratePointsCoroutine()
    {
        while (_pointsToSpawn > 0)
        {
            if (_pointsToSpawn is <= 50 and > 40)
            {
                _timeBetweenSpawns = 1.5f;
            }
            else if (_pointsToSpawn is <= 40 and > 30)
            {
                _timeBetweenSpawns = 1f;
            }
            else if (_pointsToSpawn is <= 30 and > 20)
            {
                _timeBetweenSpawns = 0.75f;
            }
            else if (_pointsToSpawn is <= 20 and > 10)
            {
                _timeBetweenSpawns = 0.5f;
            }
            else if (_pointsToSpawn is <= 10 and > 0)
            {
                _timeBetweenSpawns = 0.33f;
            }

            yield return new WaitForSeconds(_timeBetweenSpawns);

            Canvas canvas = FindObjectOfType<Canvas>();
            GameObject newPoint = Instantiate(pointPreFab, canvas.transform, true);

            newPoint.transform.localPosition = new Vector3(Random.Range(-Screen.width / 2 + 100, Screen.width / 2 - 100),
                Random.Range(-Screen.height / 2 + 100, 300), 1);
            
            _pointsToSpawn--;
        }
    }

    private void EndLevel()
    {
        buttonExit.SetActive(true);
        nextButton.SetActive(true);
        textDescriptionGameObject.SetActive(true);
        timeTextGameObject.SetActive(false);
        scoreTextGameObject.SetActive(false);

        textDescription.text = "Your final time: " + _timer + " [s]";

        DataToDbdto.LvlAimTime = _timer;
        if (_timer < 43f)
        {
            GamesCategoryPointsHelper.AddPoints(2,2,5,3,2,3,2,3,2);
        }
        else if (_timer is > 43f and <= 45f)
        {
            GamesCategoryPointsHelper.AddPoints(1,1,3,1,1,1,1,1,1);
        }
        else if (_timer is > 45f and <= 47f)
        {
            GamesCategoryPointsHelper.AddPoints(1,1,0,0,1,0,1,0,1);
        }
        else if (_timer is > 47f and <= 49f)
        {
            GamesCategoryPointsHelper.AddPoints(0,0,-3,-1,0,-1,0,-1,0);
        }
        else if (_timer > 49f)
        {
            GamesCategoryPointsHelper.AddPoints(0,0,-5,-3,0,-3,0,-3,0);
        }
    }

    public void nextButtonOnClick()
    {
        SceneManager.LoadScene("AimLevelMOS");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
