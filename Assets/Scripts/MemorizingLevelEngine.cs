using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class MemorizingLevelEngine : MonoBehaviour
{
    [SerializeField] private GameObject descriptionTextGameObjet;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonExit;
    [SerializeField] private GameObject displayTextGameObject;
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private GameObject infoTextGameObject;
    [SerializeField] private TMP_Text infoText;
    [SerializeField] private GameObject inputFieldGameObject;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private GameObject checkButton;
    [SerializeField] private GameObject nextButton;

    private int _lives;
    private int _currentSequenceIndex;
    private string _sequence;
    private bool _waitingForInput;
    
    void Start()
    {
        descriptionTextGameObjet.SetActive(true);
        buttonStart.SetActive(true);
        buttonExit.SetActive(true);
        displayTextGameObject.SetActive(false);
        infoTextGameObject.SetActive(false);
        inputFieldGameObject.SetActive(false);
        checkButton.SetActive(false);
        nextButton.SetActive(false);

        _lives = 3;
        _currentSequenceIndex = 1;
        _sequence = "";
        _waitingForInput = false;
    }
    
    public void StartGame()
    {
        descriptionTextGameObjet.SetActive(false);
        buttonStart.SetActive(false);
        buttonExit.SetActive(false);
        infoTextGameObject.SetActive(true);
        displayTextGameObject.SetActive(true);
        
        StartCoroutine(StartLevel());
    }
    
    private IEnumerator StartLevel()
    {
        while (_lives > 0)
        {
            yield return new WaitForSeconds(2f);
            
            // preparing
            inputField.text = "";
            _sequence = "";

            // Generate Number Sequence
            GenerateNumberSequence();
            displayText.text = _sequence;

            // The player has 10 seconds to remember
            yield return new WaitForSeconds(10f); 

            // After 10 second - real level
            displayTextGameObject.SetActive(false);
            inputFieldGameObject.SetActive(true);
            checkButton.SetActive(true);
            
            // result
            _waitingForInput = true;
            yield return new WaitUntil(() => !_waitingForInput);
        }
        
        displayText.text = "No more Lives - The End";
        nextButton.SetActive(true);
        buttonExit.SetActive(true);
    }
    
    private void GenerateNumberSequence()
    {
        for (int i = 0; i < _currentSequenceIndex; i++)
        {
            int number = Random.Range(0, 10);
            _sequence += number.ToString();
        }
    }
    
    public void CheckAnswer()
    {
        inputFieldGameObject.SetActive(false);
        checkButton.SetActive(false);
        displayTextGameObject.SetActive(true);
        if (_waitingForInput)
        {
            if (inputField.text.Equals(_sequence))
            {
                _currentSequenceIndex++;
                displayText.text = "Correct answer!";
            }
            else
            {
                displayText.text = "Incorrect answer :(";
                _lives--;
            }
            infoText.text = "Level: " + _currentSequenceIndex + " Lives: " + _lives;
            _waitingForInput = false;
        }
    }

    public void NextButtonOnClick()
    {
        DataToDbdto.LvlMemorizingResult = _currentSequenceIndex;

        if (_currentSequenceIndex <= 5)
        {
            GamesCategoryPointsHelper.AddPoints(-3,-3,-1,-2,-2,-1,-2,-1,-1);
        }
        else if (_currentSequenceIndex == 6 || _currentSequenceIndex == 7)
        {
            GamesCategoryPointsHelper.AddPoints(-1,-1,0,-1,-1,0,-1,0,0);
        }
        else if (_currentSequenceIndex == 8)
        {
            GamesCategoryPointsHelper.AddPoints(1,1,1,1,1,1,1,1,1);
        }
        else if (_currentSequenceIndex == 9)
        {
            GamesCategoryPointsHelper.AddPoints(3,3,1,2,2,1,2,1,1);
        }
        else if (_currentSequenceIndex >= 10)
        {
            GamesCategoryPointsHelper.AddPoints(5,5,2,3,3,2,3,2,2);
        }
        
        GamesCategoryPointsHelper.ShowPointsMap();
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
