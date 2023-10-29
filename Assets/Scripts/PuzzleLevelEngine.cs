using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleLevelEngine : MonoBehaviour
{
    [SerializeField] private GameObject descriptionTextGameObjet;
    [SerializeField] private GameObject buttonPlStart;
    [SerializeField] private GameObject buttonEngStart;
    [SerializeField] private GameObject buttonExit;
    [SerializeField] private GameObject infoTextGameObject;
    [SerializeField] private TMP_Text infoText;
    [SerializeField] private GameObject inputFieldGameObject;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private GameObject buttonCheck;
    [SerializeField] private GameObject buttonGiveUp;
    [SerializeField] private GameObject buttonNext;
    [SerializeField] private GameObject timerTextGameObject;
    [SerializeField] private TMP_Text timerText;

    private string _chosenLanguage;
    private float _timer;
    private Coroutine _timerCoroutine;

    private void Start()
    {
        descriptionTextGameObjet.SetActive(true);
        buttonPlStart.SetActive(true);
        buttonEngStart.SetActive(true);
        buttonExit.SetActive(true);
        infoTextGameObject.SetActive(false);
        inputFieldGameObject.SetActive(false);
        buttonCheck.SetActive(false);
        buttonGiveUp.SetActive(false);
        buttonNext.SetActive(false);
        timerTextGameObject.SetActive(false);

        _timer = 0f;
    }
    
    private IEnumerator StartTimer()
    {
        while (true)
        {
            _timer += Time.deltaTime;
            timerText.text = _timer.ToString("F1") + " [s]"; 
            yield return null; 
        }
    }

    public void ButtonPlStartOnClick()
    {
        buttonPlStart.SetActive(false);
        buttonEngStart.SetActive(false);
        buttonExit.SetActive(false);
        descriptionTextGameObjet.SetActive(false);
        infoTextGameObject.SetActive(true);
        inputFieldGameObject.SetActive(true);
        buttonCheck.SetActive(true);
        buttonGiveUp.SetActive(true);
        timerTextGameObject.SetActive(true);

        _chosenLanguage = "PL";
        
        infoText.text =
            "Ma mnie każdy, lecz nie każdy lubi – potrafisz uwierzyć? Możesz mnie dotknąć, zobaczyć, lecz " +
            "nie zdołasz uderzyć. Bawię dziecko, przygnębiam starca, cieszę dziewczę urocze. Kiedy płaczesz " +
            "– ja szlocham, gdy się śmiejesz - i ja chichoczę.";

        inputField.placeholder.GetComponent<TextMeshProUGUI>().text = "Odpowiedź";

        _timerCoroutine = StartCoroutine(StartTimer());
    }

    public void ButtonEngStartOnClick()
    {
        buttonPlStart.SetActive(false);
        buttonEngStart.SetActive(false);
        buttonExit.SetActive(false);
        descriptionTextGameObjet.SetActive(false);
        infoTextGameObject.SetActive(true);
        inputFieldGameObject.SetActive(true);
        buttonCheck.SetActive(true);
        buttonGiveUp.SetActive(true);
        timerTextGameObject.SetActive(true);
        
        _chosenLanguage = "ENG";

        infoText.text = 
            "To all things and men I appertain, and yet by some am shunned and distained. " +
            "Fondle me and ogle me til you're insane, but no blow can harm me, cause me pain. " +
            "Children delight in me, elders take fright. Fair maids rejoice and spin. Cry and I weep, " +
            "yawn and I sleep. Smile, and I shal grin.";

        inputField.placeholder.GetComponent<TextMeshProUGUI>().text = "Answer";
        
        _timerCoroutine = StartCoroutine(StartTimer());
    }

    public void checkButtonOnClick()
    {
        string answer = inputField.text.ToLower();
        
        if (_chosenLanguage.Equals("PL"))
        {
            if (answer.Equals("odbicie") || answer.Equals("lustro") || answer.Equals("zwierciadło") || answer.Equals("zwierciadlo"))
            {
                StopCoroutine(_timerCoroutine);
                EndLevel();
            }
            else
            {
                inputField.text = "";
                inputField.placeholder.GetComponent<TextMeshProUGUI>().text = "Zła odpowiedź!";
                inputField.placeholder.GetComponent<TextMeshProUGUI>().color = Color.red;
            }
        }
        
        if (_chosenLanguage.Equals("ENG"))
        {
            if (answer.Equals("reflection") || answer.Equals("mirror"))
            {
                StopCoroutine(_timerCoroutine);
                EndLevel();
            }
            else
            {
                inputField.text = "";
                inputField.placeholder.GetComponent<TextMeshProUGUI>().text = "Incorrect Answer!";
                inputField.placeholder.GetComponent<TextMeshProUGUI>().color = Color.red;
            }
        }
        
    }

    private void EndLevel()
    {
        buttonExit.SetActive(true);
        buttonNext.SetActive(true);
        inputFieldGameObject.SetActive(false);
        buttonCheck.SetActive(false);
        buttonGiveUp.SetActive(false);
        timerTextGameObject.SetActive(false);

        DataToDbdto.LvlPuzzleTime = _timer;
        infoText.text = "Your time: " + _timer.ToString("F1") + " [s]";

        if (_timer <= 60f)
        {
            GamesCategoryPointsHelper.AddPoints(2,4,0,0,3,0,5,4,3);
        }
        else if (_timer is > 60f and <= 90f)
        {
            GamesCategoryPointsHelper.AddPoints(2,3,1,1,2,1,3,2,2);
        }
        else if (_timer is > 90f and <= 120f)
        {
            GamesCategoryPointsHelper.AddPoints(1,1,1,1,1,1,1,1,1);
        }
        else if (_timer > 120f)
        {
            GamesCategoryPointsHelper.AddPoints(1,-1,2,2,0,2,-2,-1,-1);
        }
    }
    
    public void GiveUpButtonOnClick()
    {
        buttonExit.SetActive(true);
        buttonNext.SetActive(true);
        inputFieldGameObject.SetActive(false);
        buttonCheck.SetActive(false);
        buttonGiveUp.SetActive(false);
        timerTextGameObject.SetActive(false);

        DataToDbdto.LvlPuzzleTime = 9999f;
        infoText.text = "You Give Up :( - Correct answer was: reflection (odbicie)";
        GamesCategoryPointsHelper.AddPoints(0,-2,2,2,-2,2,-4,-3,-3);
    }

    public void NextOnClickButton()
    {
        SceneManager.LoadScene("PuzzleLevelMos");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
