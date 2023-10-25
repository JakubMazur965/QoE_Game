using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserDataButtonsAndInputsHelper : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField surnameInputField;
    [SerializeField] private TMP_InputField ageInputField;
    [SerializeField] private TMP_Dropdown gameDeviceDropdown;
    [SerializeField] private TMP_Dropdown genderDropdown;
    [SerializeField] private TMP_InputField gameExperienceInputField;
    [SerializeField] private TMP_Dropdown gameFrequencyDropdown;
    [SerializeField] private TMP_Dropdown glassesDropdown;
    [SerializeField] private GameObject nextButton;
    
    private const string ValidCharacters = "0123456789";

    private void Start()
    {
        ageInputField.onValueChanged.AddListener(ValidateAgeInputField);
        gameExperienceInputField.onValueChanged.AddListener(ValidateGameExperienceInputField);
        DataToDbdto.Gender = genderDropdown.options[0].text;
        DataToDbdto.GameFrequency = gameFrequencyDropdown.options[0].text;
        DataToDbdto.Glasses = glassesDropdown.options[0].text;
        DataToDbdto.GameDevice = gameDeviceDropdown.options[0].text;
    }

    private void Update()
    {
        if (DataToDbdto.Name != "" && DataToDbdto.Surname != "" && DataToDbdto.Age != 0)
        {
            nextButton.SetActive(true);
        }
    }

    public void InputNameProcess()
    {
        DataToDbdto.Name = nameInputField.text;
    }
    
    public void InputSurnameProcess()
    {
        DataToDbdto.Surname = surnameInputField.text;
    }
    
    public void InputAgeProcess()
    {
        if (!string.IsNullOrEmpty(ageInputField.text))
        {
            DataToDbdto.Age = Convert.ToInt32(ageInputField.text);
        }
    }
    
    public void OnGenderSelected()
    {
        DataToDbdto.Gender = genderDropdown.options[genderDropdown.value].text;
    }
    
    public void InputGameExperienceProcess()
    {
        DataToDbdto.GameExperience = gameExperienceInputField.text;
    }
    
    public void OnGameFrequencySelected()
    {
        DataToDbdto.GameFrequency = gameFrequencyDropdown.options[gameFrequencyDropdown.value].text;
    }
    
    public void OnGlassesSelected()
    {
        DataToDbdto.Glasses = glassesDropdown.options[glassesDropdown.value].text;
    }
    
    public void OnGameDeviceSelected()
    {
        DataToDbdto.GameDevice = gameDeviceDropdown.options[gameDeviceDropdown.value].text;
    }
    
    public void Next()
    {
        SceneManager.LoadScene("TechnicalQuestions");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    private void ValidateAgeInputField(string text)
    {
        ageInputField.text = new string(text.Where(c => ValidCharacters.Contains(c)).ToArray());
    }
    
    private void ValidateGameExperienceInputField(string text)
    {
        gameExperienceInputField.text = new string(text.Where(c => ValidCharacters.Contains(c)).ToArray());
    }
    
}
