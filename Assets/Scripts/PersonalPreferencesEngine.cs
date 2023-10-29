using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PeronalPreferencesEngine : MonoBehaviour
{
    [SerializeField] private int questionNumber;
    [SerializeField] private TMP_Text questionText;
    [SerializeField] private GameObject nextButton;
    
    void Start()
    {
        questionNumber = 1;
    }

    private void Update()
    {
        switch (questionNumber)
        {
            case 1:
                questionText.text = "Q1: If the more complicated mechanics are in the game, the more interesting the game is. [Playing Quality]";
                break;
            case 2:
                questionText.text = "Q2: The story and quests in games play the most important role. [Involvement]";
                break;
            case 3:
                questionText.text = "Q3: In games, an extensive world is very important.  [Immersion] [Presence] ";
                break;
            case 4:
                questionText.text = "Q4: When playing games, being immersed in its world is very important to me. [Immersion]";
                break;
            case 5:
                questionText.text = "Q5: After finishing the game, I spend many hours reliving the fate of its characters. [Absorption]";
                break;
            case 6:
                questionText.text = "Q6: I prefer games with a lot of action and fast pace. [Flow] [Interaction quality]";
                break;
            case 7:
                questionText.text = "Q7: The level of AI intelligence in games matters to me. [Playing Quality]";
                break;
            case 8:
                questionText.text = "Q8: In games I always choose the easiest difficulty level, I have no shame, I only care about the plot. [Playing Quality]";
                break;
            case 9:
                questionText.text = "Q9: I'm more interested in multiplayer games than single-player games. [Playing Quality]";
                break;
            case 10:
                questionText.text = "Q10: The game must provide me with many emotions. [Interaction quality] [Involvement]";
                break;
            case 11:
                questionText.text = "Q11: Games should have a motto easy to play hard to master.";
                break;
            case 12:
                questionText.text = "Q12: I love spending many hours creating a character, developing it or mastering new game mechanics. [Playing quality] [Involvement]";
                break;
            case 13:
                questionText.text = "Q13: When I play games, I feel like I'm a part of them. [Immersion] [Presence]";
                break;
            case 14:
                questionText.text = "Q14: In games, the most important thing is competition with others. [Involvement]";
                break;
            case 15:
                questionText.text = "Q15: Games must evoke many emotions in me, both positive and negative fear. [Absorption] [Flow]";
                break;
            case 16:
                questionText.text = "";
                nextButton.SetActive(true);
                break;
        }
    }

    public void StrongAgreeButton()
    {
        switch (questionNumber)
        {
            case 1:
                GamesCategoryPointsHelper.AddPoints(4,5,-5,4,5,-3,-5,-3,3);
                break;
            case 2:
                GamesCategoryPointsHelper.AddPoints(-5,-2,-2,-5,5,-5,-3,5,4);
                break;
            case 3:
                GamesCategoryPointsHelper.AddPoints(3,-5,-3,-5,5,-5,-5,4,-1);
                break;
            case 4:
                GamesCategoryPointsHelper.AddPoints(-2,-4,-3,-5,5,-5,-5,4,5);
                break;
            case 5:
                GamesCategoryPointsHelper.AddPoints(-5,-5,-2,-5,5,-5,-5,5,2);
                break;
            case 6:
                GamesCategoryPointsHelper.AddPoints(-5,-5,5,5,-3,5,-5,-2,2);
                break;
            case 7:
                GamesCategoryPointsHelper.AddPoints(2,5,5,-5,3,-5,-4,-2,3);
                break;
            case 8:
                GamesCategoryPointsHelper.AddPoints(-3,-5,-2,-3,3,-2,-2,3,2);
                break;
            case 9:
                GamesCategoryPointsHelper.AddPoints(-3,-1,5,5,-5,5,5,-4,0);
                break;
            case 10:
                GamesCategoryPointsHelper.AddPoints(-3,-3,3,-1,5,3,4,4,5);
                break;
            case 11:
                GamesCategoryPointsHelper.AddPoints(3,5,4,5,-3,5,-4,-5,2);
                break;
            case 12:
                GamesCategoryPointsHelper.AddPoints(-3,-5,-4,-5,5,-5,-5,4,-2);
                break;
            case 13:
                GamesCategoryPointsHelper.AddPoints(5,-3,3,3,5,-3,-2,4,5);
                break;
            case 14:
                GamesCategoryPointsHelper.AddPoints(2,4,5,5,-5,5,5,-5,-3);
                break;
            case 15:
                GamesCategoryPointsHelper.AddPoints(-5,-5,3,5,3,5,3,3,5);
                break;
        }
        questionNumber++;
    }
    
    public void AgreeButton()
    {
        switch (questionNumber)
        {
            case 1:
                GamesCategoryPointsHelper.AddPoints(2,4,-3,2,3,-1,-3,-2,2);
                break;
            case 2:
                GamesCategoryPointsHelper.AddPoints(-4,-1,-1,-4,3,-4,-1,3,3);
                break;
            case 3:
                GamesCategoryPointsHelper.AddPoints(2,-3,-1,-4,4,-4,-3,2,0);
                break;
            case 4:
                GamesCategoryPointsHelper.AddPoints(-1,-2,-1,-3,4,-3,-4,2,3);
                break;
            case 5:
                GamesCategoryPointsHelper.AddPoints(-3,-4,-1,-4,3,-4,-4,4,2);
                break;
            case 6:
                GamesCategoryPointsHelper.AddPoints(-4,-3,4,3,-1,4,-3,-1,3);
                break;
            case 7:
                GamesCategoryPointsHelper.AddPoints(2,4,3,-3,2,-3,-2,-1,2);
                break;
            case 8:
                GamesCategoryPointsHelper.AddPoints(-1,-3,-1,-2,2,-1,-1,2,1);
                break;
            case 9:
                GamesCategoryPointsHelper.AddPoints(-2,0,3,4,-4,4,4,-3,1);
                break;
            case 10:
                GamesCategoryPointsHelper.AddPoints(-2,-2,2,0,3,2,3,2,4);
                break;
            case 11:
                GamesCategoryPointsHelper.AddPoints(2,3,2,4,-2,3,-2,-3,1);
                break;
            case 12:
                GamesCategoryPointsHelper.AddPoints(-2,-4,-2,-4,4,-3,-2,3,-1);
                break;
            case 13:
                GamesCategoryPointsHelper.AddPoints(3,-1,2,2,4,-1,0,2,3);
                break;
            case 14:
                GamesCategoryPointsHelper.AddPoints(1,2,4,4,-3,4,4,-3,-2);
                break;
            case 15:
                GamesCategoryPointsHelper.AddPoints(-4,-4,2,2,2,2,2,2,3);
                break;
        }
        questionNumber++;
    }
    
    public void NeutralButton()
    {
        switch (questionNumber)
        {
            case 1:
                GamesCategoryPointsHelper.AddPoints(0,-3,-1,0,-2,0,-1,-1,1);
                break;
            case 2:
                GamesCategoryPointsHelper.AddPoints(-2,0,0,-2,-3,-2,1,-2,2);
                break;
            case 3:
                GamesCategoryPointsHelper.AddPoints(1,0,1,-3,-3,-2,0,-1,1);
                break;
            case 4:
                GamesCategoryPointsHelper.AddPoints(0,0,1,-1,-3,-1,-1,-1,-2);
                break;
            case 5:
                GamesCategoryPointsHelper.AddPoints(-2,-3,-1,-3,-1,-3,-2,-2,1);
                break;
            case 6:
                GamesCategoryPointsHelper.AddPoints(-2,-1,-3,-2,0,-3,-1,0,1);
                break;
            case 7:
                GamesCategoryPointsHelper.AddPoints(1,-1,0,0,1,1,-1,0,1);
                break;
            case 8:
                GamesCategoryPointsHelper.AddPoints(0,0,0,5,1,2,5,0,1);
                break;
            case 9:
                GamesCategoryPointsHelper.AddPoints(-1,2,0,-3,-3,-1,0,-1,3);
                break;
            case 10:
                GamesCategoryPointsHelper.AddPoints(0,0,1,1,0,2,2,-1,-2);
                break;
            case 11:
                GamesCategoryPointsHelper.AddPoints(1,0,0,-3,0,-2,0,0,1);
                break;
            case 12:
                GamesCategoryPointsHelper.AddPoints(0,-2,-1,-3,-1,-1,2,3,1);
                break;
            case 13:
                GamesCategoryPointsHelper.AddPoints(1,2,1,0,0,1,3,0,1);
                break;
            case 14:
                GamesCategoryPointsHelper.AddPoints(1,1,-2,-3,-1,-3,1,-1,-1);
                break;
            case 15:
                GamesCategoryPointsHelper.AddPoints(0,0,1,1,1,1,1,1,1);
                break;
        }
        questionNumber++;
    }
    
    public void DisagreeButton()
    {
        switch (questionNumber)
        {
            case 1:
                GamesCategoryPointsHelper.AddPoints(-2,-4,3,-2,-3,1,2,2,0);
                break;
            case 2:
                GamesCategoryPointsHelper.AddPoints(4,2,2,3,-4,4,3,-4,2);
                break;
            case 3:
                GamesCategoryPointsHelper.AddPoints(0,3,2,3,-4,3,3,-2,2);
                break;
            case 4:
                GamesCategoryPointsHelper.AddPoints(2,3,2,3,-4,3,3,-2,-3);
                break;
            case 5:
                GamesCategoryPointsHelper.AddPoints(4,4,3,4,-4,4,4,-4,1);
                break;
            case 6:
                GamesCategoryPointsHelper.AddPoints(4,3,-4,-4,3,-4,4,3,0);
                break;
            case 7:
                GamesCategoryPointsHelper.AddPoints(1,-3,-2,3,-1,3,4,1,0);
                break;
            case 8:
                GamesCategoryPointsHelper.AddPoints(2,3,1,4,2,2,4,1,1);
                break;
            case 9:
                GamesCategoryPointsHelper.AddPoints(2,3,-1,-4,4,-2,-1,2,4);
                break;
            case 10:
                GamesCategoryPointsHelper.AddPoints(2,2,0,2,-3,2,1,-2,-4);
                break;
            case 11:
                GamesCategoryPointsHelper.AddPoints(0,-3,-2,-4,2,-4,3,2,1);
                break;
            case 12:
                GamesCategoryPointsHelper.AddPoints(3,3,2,4,-3,3,3,3,3);
                break;
            case 13:
                GamesCategoryPointsHelper.AddPoints(0,4,0,2,-1,2,4,-2,-2);
                break;
            case 14:
                GamesCategoryPointsHelper.AddPoints(2,1,-4,-4,3,-4,0,3,4);
                break;
            case 15:
                GamesCategoryPointsHelper.AddPoints(3,3,0,0,2,0,2,2,0);
                break;
        }
        questionNumber++;
    }
    
    public void StrongDisagreeButton()
    {
        switch (questionNumber)
        {
            case 1:
                GamesCategoryPointsHelper.AddPoints(-4,-5,5,-4,-4,3,5,5,-1);
                break;
            case 2:
                GamesCategoryPointsHelper.AddPoints(5,4,4,5,-5,5,5,-5,0);
                break;
            case 3:
                GamesCategoryPointsHelper.AddPoints(1,5,3,5,-5,5,5,-4,4);
                break;
            case 4:
                GamesCategoryPointsHelper.AddPoints(4,5,4,5,-5,5,5,-4,-5);
                break;
            case 5:
                GamesCategoryPointsHelper.AddPoints(5,5,4,5,-5,5,5,-5,0);
                break;
            case 6:
                GamesCategoryPointsHelper.AddPoints(5,5,-5,-5,5,-5,5,5,-1);
                break;
            case 7:
                GamesCategoryPointsHelper.AddPoints(0,-5,-4,5,-2,5,5,2,-1);
                break;
            case 8:
                GamesCategoryPointsHelper.AddPoints(4,5,2,3,3,3,3,2,2);
                break;
            case 9:
                GamesCategoryPointsHelper.AddPoints(4,4,-3,-5,5,-4,-2,5,5);
                break;
            case 10:
                GamesCategoryPointsHelper.AddPoints(4,4,-2,3,-5,3,0,-4,-5);
                break;
            case 11:
                GamesCategoryPointsHelper.AddPoints(-1,-5,4,-5,4,-5,5,4,2);
                break;
            case 12:
                GamesCategoryPointsHelper.AddPoints(4,5,4,5,-5,5,5,2,5);
                break;
            case 13:
                GamesCategoryPointsHelper.AddPoints(-1,5,-1,3,-3,4,5,-4,-4);
                break;
            case 14:
                GamesCategoryPointsHelper.AddPoints(3,2,-5,-5,5,-5,-2,5,5);
                break;
            case 15:
                GamesCategoryPointsHelper.AddPoints(5,5,0,-2,3,-2,3,3,-1);
                break;
        }
        questionNumber++;
    }
    
    public void Next()
    {
        SceneManager.LoadScene("PracticalPartIntroduction");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
