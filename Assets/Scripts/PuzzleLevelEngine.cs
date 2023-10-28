using System;
using TMPro;
using UnityEngine;

public class PuzzleLevelEngine : MonoBehaviour
{
    [SerializeField] private GameObject descriptionTextGameObjet;
    [SerializeField] private GameObject buttonPLStart;
    [SerializeField] private GameObject buttonENGStart;
    [SerializeField] private GameObject buttonExit;
    [SerializeField] private GameObject infoTextGameObject;
    [SerializeField] private TMP_Text infoText;
    [SerializeField] private GameObject inputFieldGameObject;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private GameObject buttonCheck;
    [SerializeField] private GameObject buttonGiveUp;
    [SerializeField] private GameObject buttonNext;

    private string _chosenLanguage;

    private void Start()
    {
        descriptionTextGameObjet.SetActive(true);
        buttonPLStart.SetActive(true);
        buttonENGStart.SetActive(true);
        buttonExit.SetActive(true);
        infoTextGameObject.SetActive(false);
        inputFieldGameObject.SetActive(false);
        buttonCheck.SetActive(false);
        buttonGiveUp.SetActive(false);
        buttonNext.SetActive(false);
    }

    public void ButtonPlStartOnClick()
    {
        buttonPLStart.SetActive(false);
        buttonENGStart.SetActive(false);
        buttonExit.SetActive(false);
        descriptionTextGameObjet.SetActive(false);
        infoTextGameObject.SetActive(true);
        inputFieldGameObject.SetActive(true);
        buttonCheck.SetActive(true);
        buttonGiveUp.SetActive(true);

        _chosenLanguage = "PL";
        
        infoText.text =
            "Ma mnie każdy, lecz nie każdy lubi – potrafisz uwierzyć? Możesz mnie dotknąć, zobaczyć, lecz " +
            "nie zdołasz uderzyć. Bawię dziecko, przygnębiam starca, cieszę dziewczę urocze. Kiedy płaczesz " +
            "– ja szlocham, gdy się śmiejesz - i ja chichoczę.";

        inputField.placeholder.GetComponent<TextMeshProUGUI>().text = "Odpowiedź";
    }

    public void ButtonEngStartOnClick()
    {
        buttonPLStart.SetActive(false);
        buttonENGStart.SetActive(false);
        buttonExit.SetActive(false);
        descriptionTextGameObjet.SetActive(false);
        infoTextGameObject.SetActive(true);
        inputFieldGameObject.SetActive(true);
        buttonCheck.SetActive(true);
        buttonGiveUp.SetActive(true);
        
        _chosenLanguage = "ENG";

        infoText.text = 
            "To all things and men I appertain, and yet by some am shunned and distained. " +
            "Fondle me and ogle me til you're insane, but no blow can harm me, cause me pain. " +
            "Children delight in me, elders take fright. Fair maids rejoice and spin. Cry and I weep, " +
            "yawn and I sleep. Smile, and I shal grin.";

        inputField.placeholder.GetComponent<TextMeshProUGUI>().text = "Answer";
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
