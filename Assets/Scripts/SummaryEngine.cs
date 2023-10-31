using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SummaryEngine : MonoBehaviour
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
    [SerializeField] private GameObject thirdNextGameObject;


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

    private Dictionary<string, int> _categoriesPointMap;
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
        thirdNextGameObject.SetActive(false);
        
        _categoriesPointMap = GamesCategoryPointsHelper.GetCategoriesPointMap();
        
        DataToDbdto.SystemRecommendation = _categoriesPointMap.First().Key;
        DataToDbdto.SystemRecommendationAllData = GetAllDataForRecommendation();
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

        titleText.text = "Recommendation: " + _categoriesPointMap.First().Key + ". Score: " +
                         _categoriesPointMap.First().Value + " Points";
        
        switch (_categoriesPointMap.First().Key)
        {
            case "Simulation and Sandbox":
                summaryText.text = "Simulation and Sandbox - The term “sandbox” may be more recognizable from its " +
                                   "usage in tech or even as an open-ended mode available within certain games. " +
                                   "It’s often associated with player choice, open environments, and non-linear " +
                                   "gameplay. The sandbox genre has grown from a small niche to encompass a huge " +
                                   "variety of titles. In these games, players often have less concrete goals and " +
                                   "narrative pathways to pursue. Instead of beating the boss and saving the princess, " +
                                   "you may face a variety of tasks you can accomplish in a number of different ways. " +
                                   "This draws players into more immersive experiences, encouraging experimentation " +
                                   "with what may be unfamiliar mechanics. Simulations - These games involve taking" +
                                   " a real job or doing real activities like driving a truck. These games are often " +
                                   "played not only by amateurs but also by professionals in a given field. " +
                                   "In fact, many pilots are trained using aircraft simulators before they actually fly.";
                firstImage.sprite = minecraftSprite;
                firstImageText.text = "Minecraft (2011)";
                secondImage.sprite = citySkylinesIISprite;
                secondImageText.text = "Cities Skylines 2 (2023)";
                break;
            
            case "Real-time strategy (RTS) and Strategy":
                summaryText.text = "Real-time strategy (RTS) and Strategy - Strategy - A strategy game or strategic " +
                                   "game is a game in which the players' uncoerced, and often autonomous, " +
                                   "decision-making skills have a high significance in determining the outcome. " +
                                   "Almost all strategy games require internal decision tree-style thinking, and " +
                                   "typically very high situational awareness. RTS - In the archetypal " +
                                   "RTS title, Dune II human and AI players control different factions and compete " +
                                   "against each other simultaneously in “real time” hence the term “real-time " +
                                   "strategy,” as opposed to turn-based strategy. These games typically include " +
                                   "resource and map management, and they often feature a top-down view.";
                firstImage.sprite = twierdzaSprite;
                firstImageText.text = "Stronghold (2001)";
                secondImage.sprite = heroesIIISprite;
                secondImageText.text = "Heroes of Might and Magic III (1999)";
                break;
            
            case "Shooters (FPS and TPS)":
                summaryText.text = "Shooters (FPS and TPS) - The shooter is another long-standing genre that " +
                                   "developed several early offshoots and branched out into two primary sub-genres: " +
                                   "the first-person shooter (FPS) and third-person shooter (TPS). There’s plenty of " +
                                   "potential for overlap here, too, since many contemporary titles allow you to " +
                                   "toggle between first and third-person viewpoints. Not only that, but most battle " +
                                   "royale games – a sub-genre unto itself – operate as either first or third-person " +
                                   "shooters, including Fortnite and PlayerUnknown’s Battlegrounds.";
                firstImage.sprite = codSprite;
                firstImageText.text = "Call of Duty Black (2010)";
                secondImage.sprite = csSprite;
                secondImageText.text = "Counter Strike 2 (2023)";
                break;
            
            case "Multiplayer online battle arena (MOBA)":
                summaryText.text = "Multiplayer online battle arena (MOBA) - An increasingly popular subgenre with " +
                                   "connections to a variety of other styles, multiplayer online battle arena games " +
                                   "share many features with real-time strategy games. There’s a top-down perspective " +
                                   "that emphasizes map and resource management, plus real-time competition between " +
                                   "players. MOBA games also prioritize multiplayer and team play. While some " +
                                   "well-known titles feature AI-controlled elements, you usually play with and " +
                                   "compete against other human players to meet a set of victory conditions. " +
                                   "The niche is dominated by Dota 2 and League of Legends, both of which have " +
                                   "developed substantial audiences in eSports.";
                firstImage.sprite = lolSprite;
                firstImageText.text = "League of Legends (2009)";
                secondImage.sprite = dotaIISprite;
                secondImageText.text = "Dota 2 (2013)";
                break;
            
            case "Role-playing (RPG, ARPG)":
                summaryText.text = "Role-playing (RPG, ARPG) - The basic premise of the role-playing game is simple " +
                                   "and ubiquitous in numerous games: you create or take control of a character that " +
                                   "you can then level up through experience points. RPGs are a cornerstone of gaming, " +
                                   "but no single game can represent the genre because it’s grown and blossomed into " +
                                   "numerous sub-genres. With that in mind, here are the most popular sub-genres " +
                                   "with a short explanation for each. While you may see other RPG-associated terms " +
                                   "used during gaming discussions, these are some of the most common ones to keep " +
                                   "in mind.";
                firstImage.sprite = wiedzminIIISprite;
                firstImageText.text = "The Witcher III Wild Hunt (2015)";
                secondImage.sprite = gothicIISprite;
                secondImageText.text = "Gothic 2 Night of the Raven (2003)";
                break;
            
            case "Sports, Combat and Racing":
                summaryText.text = "Sports, Combat and Racing - These genres have evolved a lot over the years and " +
                                   "you may actually see them in the same light. But it’s only with advances in " +
                                   "graphics technology that they’ve begun to offer unique immersive experiences. " +
                                   "The latest iterations provide impressive levels of detail and showcase just how " +
                                   "much is possible with games. Sports games have expanded in variety, " +
                                   "offering full-fledged partnerships with major sporting organizations, from race " +
                                   "tracks to the field or court. NBA 2K and Madden NFL are two well-known examples " +
                                   "that feature detailed recreations of professional basketball and football, " +
                                   "while Forza is a simulation-style car racing game.";
                firstImage.sprite = fc24Sprite;
                firstImageText.text = "FC 24 (2023)";
                secondImage.sprite = mortalKombatISprite;
                secondImageText.text = "Mortal Kombat 1 (2023)";
                break;
            
            case "Party Games, Puzzles":
                summaryText.text = "Party Games, Puzzles - Puzzlers and party games also have a significant overlap, " +
                                   "with both emphasizing game mechanics. You can expect to play a game based on a " +
                                   "theme or a traditional tabletop game with particular rule sets. Party games take " +
                                   "that premise a little further and often include multiplayer elements. They also " +
                                   "double-down on gameplay. The Mario Party series is particularly popular, and it " +
                                   "spawned more than 10 installments and spin-offs. Puzzlers, also known as puzzle " +
                                   "games, can be as simple as Minesweeper or more deeply immersive, with fully " +
                                   "developed environments and hybrid gameplay.";
                firstImage.sprite = toJestesTySprite;
                firstImageText.text = "That's You! (2017)";
                secondImage.sprite = wiedzaToPotegaSprite;
                secondImageText.text = "Knowledge is Power (2017)";
                break;
            
            case "Action-Adventure":
                summaryText.text = "Action-Adventure - Among the earliest recognizable hybrid genres, action-adventure " +
                                   "games have a deep focus on plot and combat through story involvement and tight " +
                                   "gameplay mechanics. As a result, many games can fit into this category, " +
                                   "including the classic Legend of Zelda franchise that paved the way for numerous " +
                                   "franchises. Most users draw the line between action and adventure in how a game " +
                                   "balances story and features like simulated combat. Ubisoft’s Assassin’s Creed " +
                                   "series has been a mainstay since 2007 thanks to near-annual new releases " +
                                   "featuring a high degree of immersion. They have also taken gamers to myriad " +
                                   "locales and historical landscapes ranging from London during the Industrial " +
                                   "Revolution (Syndicate) to ancient Greece (Odyssey).";
                firstImage.sprite = unchartedIVSprite;
                firstImageText.text = "Uncharted 4: A Thief's End (2016)";
                secondImage.sprite = tombRaiderSprite;
                secondImageText.text = "Shadow of the Tomb Raider (2018)";
                break;
            
            case "Survival and horror":
                summaryText.text = "Survival and horror - Survival and horror games have a lot of overlap, to the " +
                                   "point that they even created their own sub-genre (survival horror). In particular, " +
                                   "horror games often share some basic features with their survival counterparts, " +
                                   "though the reverse is less often true. As developers add more FPS and conventional " +
                                   "shooter features to certain horror and survival titles, there’s even ongoing debate " +
                                   "about how to define these games.";
                firstImage.sprite = residentEvilVIISprite;
                firstImageText.text = "Resident Evil VII: Biohazard (2017)";
                secondImage.sprite = layersOfFearSprite;
                secondImageText.text = "Layers of Fear (2016)";
                break;
        }
    }

    public void secondNextButtonOnClick()
    {
        firstImageGameObject.SetActive(false);
        secondImageGameObject.SetActive(false);
        firstImageTextGameObject.SetActive(false);
        secondImageTextGameObject.SetActive(false);
        secondNextGameObject.SetActive(false);
        thirdNextGameObject.SetActive(true);

        summaryText.text = "";
        foreach (var kvp in _categoriesPointMap.Skip(1))
        {
            summaryText.text = summaryText.text + kvp.Key + ", Score: " + kvp.Value + " Points\n";
        }

        titleText.text = "Remaining Results";
    }

    public void thirdNextButtonOnClick()
    {
        SceneManager.LoadScene("RecommendationMos");
    }

    private string GetAllDataForRecommendation()
    {
        string result = "";

        foreach (var kvp in _categoriesPointMap)
        {
            result += kvp.Key + ":" + kvp.Value + ",";
        }

        return result;
    }

}
