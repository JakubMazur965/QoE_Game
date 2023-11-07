using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EducationEndingEngine : MonoBehaviour
{
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private GameObject descriptionText;
    [SerializeField] private TMP_Text summaryText;
    [SerializeField] private GameObject summaryTextGameObject;
    [SerializeField] private Image firstImage;
    [SerializeField] private GameObject firstImageGameObject;
    [SerializeField] private Image secondImage;
    [SerializeField] private GameObject secondImageGameObject;
    [SerializeField] private TMP_Text firstImageText;
    [SerializeField] private GameObject firstImageTextGameObject;
    [SerializeField] private TMP_Text secondImageText;
    [SerializeField] private GameObject secondImageTextGameObject;
    [SerializeField] private GameObject nextGameObject;
    [SerializeField] private GameObject secondNextGameObject;

    [SerializeField] private Sprite marcoPoloSprite;
    [SerializeField] private Sprite worldAtlasSprite;
    
    void Start()
    {
        descriptionText.SetActive(true);
        summaryTextGameObject.SetActive(false);
        firstImageGameObject.SetActive(false);
        secondImageGameObject.SetActive(false);
        firstImageTextGameObject.SetActive(false);
        secondImageTextGameObject.SetActive(false);
        nextGameObject.SetActive(true);
        secondNextGameObject.SetActive(false);
    }

    public void nextButtonOnClick()
    {
        descriptionText.SetActive(false);
        summaryTextGameObject.SetActive(true);
        firstImageGameObject.SetActive(true);
        secondImageGameObject.SetActive(true);
        firstImageTextGameObject.SetActive(true);
        secondImageTextGameObject.SetActive(true);
        nextGameObject.SetActive(false);
        secondNextGameObject.SetActive(true);

        titleText.text = "Recommendation: Children and Education.";
        
        summaryText.text = "While many parents and teachers complain about video games, there are some great " +
                           "educational games out there that can help with the learning process. Train in a " +
                           "variety of subjects, using games to make learning fun instead of boring. There are " +
                           "testing functions, where you can answer multiple choice questions. The most common types " +
                           "of education games are for math, science, and ICT.";
        firstImage.sprite = marcoPoloSprite;
        firstImageText.text = "Marco Polo World School (2020)";
        secondImage.sprite = worldAtlasSprite;
        secondImageText.text = "Barefoot World Atlas (2018)";
        
    }

    public void secondNextButtonOnClick()
    {
        DataToDbdto.SystemRecommendation = "Children and Education";
        DBHelper.SaveAllDataToDB();
        SceneManager.LoadScene("TheEnd");
    }
}
