using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SummaryEngine : MonoBehaviour
{
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

    [SerializeField] private Sprite minecraftSprite;
    [SerializeField] private Sprite citySkylinesIISprite;
    [SerializeField] private Sprite twierdzaSprite;
    [SerializeField] private Sprite heroesIIISprite;
    [SerializeField] private Sprite codSprite;
    [SerializeField] private Sprite csSprite;
    [SerializeField] private Sprite lolSprite;
    [SerializeField] private Sprite dotaIISprite;
    [SerializeField] private Sprite wiedzminIIISprite;
    [SerializeField] private Sprite gothicIISprite;
    [SerializeField] private Sprite fc24Sprite;
    [SerializeField] private Sprite mortalKombatISprite;
    [SerializeField] private Sprite toJestesTySprite;
    [SerializeField] private Sprite wiedzaToPotegaSprite;
    [SerializeField] private Sprite unchartedIVSprite;
    [SerializeField] private Sprite tombRaiderSprite;
    [SerializeField] private Sprite residentEvilVIISprite;
    [SerializeField] private Sprite layersOfFearSprite;

    private int _nextMeter;
    void Start()
    {
        descriptionText.SetActive(true);
        summaryTextGameObject.SetActive(false);
        firstImageGameObject.SetActive(false);
        secondImageGameObject.SetActive(false);
        firstImageTextGameObject.SetActive(false);
        secondImageTextGameObject.SetActive(false);

        _nextMeter = 0;
    }

    public void nextButtonOnClick()
    {
        if (_nextMeter == 0)
        {
            descriptionText.SetActive(false);
            summaryTextGameObject.SetActive(true);
            firstImageGameObject.SetActive(true);
            secondImageGameObject.SetActive(true);
            firstImageTextGameObject.SetActive(true);
            secondImageTextGameObject.SetActive(true);

            Dictionary<string, int> categoriesPointMap = GamesCategoryPointsHelper.GetCategoriesPointMap();

            switch (categoriesPointMap.First().Key)
            {
                case "Simulation and Sandbox":
                    summaryText.text = "Simulation and Sandbox";
                    firstImage.sprite = minecraftSprite;
                    firstImageText.text = "Minecraft (2011)";
                    secondImage.sprite = citySkylinesIISprite;
                    secondImageText.text = "Cities Skylines 2 (2023)";
                    break;
                
                case "Real-time strategy (RTS) and Strategy":
                    summaryText.text = "Real-time strategy (RTS) and Strategy";
                    firstImage.sprite = twierdzaSprite;
                    firstImageText.text = "Stronghold (2001)";
                    secondImage.sprite = heroesIIISprite;
                    secondImageText.text = "Heroes of Might and Magic III (1999)";
                    break;
                
                case "Shooters (FPS and TPS)":
                    summaryText.text = "Shooters (FPS and TPS)";
                    firstImage.sprite = codSprite;
                    firstImageText.text = "Call of Duty Black  (2010)";
                    secondImage.sprite = csSprite;
                    secondImageText.text = "Counter Strike 2 (2023)";
                    break;
                
                case "Multiplayer online battle arena (MOBA)":
                    summaryText.text = "Multiplayer online battle arena (MOBA)";
                    firstImage.sprite = lolSprite;
                    firstImageText.text = "League of Legends (2009)";
                    secondImage.sprite = dotaIISprite;
                    secondImageText.text = "Dota 2 (2013)";
                    break;
                
                case "Role-playing (RPG, ARPG)":
                    summaryText.text = "Role-playing (RPG, ARPG)";
                    firstImage.sprite = wiedzminIIISprite;
                    firstImageText.text = "The Witcher III Wild Hunt (2015)";
                    secondImage.sprite = gothicIISprite;
                    secondImageText.text = "Gothic 2 Night of the Raven (2003)";
                    break;
                
                case "Sports, Combat and Racing":
                    summaryText.text = "Sports, Combat and Racing";
                    firstImage.sprite = fc24Sprite;
                    firstImageText.text = "FC 24 (2023)";
                    secondImage.sprite = mortalKombatISprite;
                    secondImageText.text = "Mortal Kombat 1 (2023)";
                    break;
                
                case "Party Games, Puzzles":
                    summaryText.text = "Party Games, Puzzles";
                    firstImage.sprite = toJestesTySprite;
                    firstImageText.text = "That's You! (2017)";
                    secondImage.sprite = wiedzaToPotegaSprite;
                    secondImageText.text = "Knowledge is Power (2017)";
                    break;
                
                case "Action-Adventure":
                    summaryText.text = "Action-Adventure";
                    firstImage.sprite = unchartedIVSprite;
                    firstImageText.text = "Uncharted 4: A Thief's End (2016)";
                    secondImage.sprite = tombRaiderSprite;
                    secondImageText.text = "Shadow of the Tomb Raider (2018)";
                    break;
                
                case "Survival and horror":
                    summaryText.text = "Survival and horror";
                    firstImage.sprite = residentEvilVIISprite;
                    firstImageText.text = "Resident Evil VII: Biohazard (2017)";
                    secondImage.sprite = layersOfFearSprite;
                    secondImageText.text = "Layers of Fear (2016)";
                    break;
            }
            
            _nextMeter++;
        }

        if (_nextMeter == 1)
        {
            
        }
    }
    
}
