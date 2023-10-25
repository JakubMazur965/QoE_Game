using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TechnicalQuestionsEngine : MonoBehaviour
{

    [SerializeField] private int questionNumber;
    [SerializeField] private TMP_Text questionText;
    
    void Start()
    {
        questionNumber = 1;
    }

    private void Update()
    {
        switch (questionNumber)
        {
            case 1:
                questionText.text = "Q1: Graphics in games are very important. [Aesthetics]";
                break;
            case 2:
                questionText.text = "Q2: Smooth animation in games is crucial to play comfortably. [The Appeal]";
                break;
            case 3:
                questionText.text = "Q3: I always adjusts the graphics settings of my game to achieve optimal performance and graphics quality. [Aesthetics]";
                break;
            case 4:
                questionText.text = "Q4: I prefer games with a minimalist visual style rather than those with extensive 3D graphics. [Aesthetics]";
                break;
            case 5:
                questionText.text = "Q5: I always pay attention to the quality of textures and details in a game. The game looks weak without them. [Aesthetics]";
                break;
            case 6:
                questionText.text = "Q6: I always use advanced graphics settings in games, such as ray tracing. [The Appeal]";
                break;
            case 7:
                questionText.text = "Q7: Are you interested in screen resolution in games? [Aesthetics]";
                break;
            case 8:
                questionText.text = "Q8: Consistent and high frames per second (FPS) rates are very important in games. [Interaction Quality]";
                break;
            case 9:
                questionText.text = "Q9: Playing at 30 frames per second (FPS) is not a problem for me. [Interaction Quality]";
                break;
            case 10:
                questionText.text = "Q10: Do you prefer games with advanced lighting effects such as HDR or weather effects? [The Appeal] [Aesthetics]";
                break;
            case 11:
                questionText.text = "Q11: The quality of sound and soundtrack is really important in games. [The Appeal]";
                break;
            case 12:
                questionText.text = "Q12: Fast internet is very important during playing games. [Interaction Quality]";
                break;
            case 13:
                questionText.text = "Q13: Is high delay (over 120ms) a factor that prevents you from playing freely? [Interaction Quality]";
                break;
            case 14:
                questionText.text = "Q14: I feel a difference in the game if the monitor has a refresh rate of 144MHz and 60MHz. [Interaction Quality]";
                break;
            case 15:
                questionText.text = "Q15: There is a big difference when playing at 120 frames per second (FPS) compared to playing at 60 frames per second (FPS). [Interaction Quality]";
                break;
            case 16:
                break;
        }
    }

    public void StrongAgreeButton()
    {
        switch (questionNumber)
        {
            case 1:
                GamesCategoryPointsHelper.AddPoints(5, 3, 3, 1, 5, 5, 5, 5, 3);
                questionNumber++;
                break;
            case 2:
                GamesCategoryPointsHelper.AddPoints(5, 3, 5, 4, 5, 2, 3, 4, 3);
                questionNumber++;
                break;
            case 3:
                GamesCategoryPointsHelper.AddPoints(3, 0, 5, 0, 5, 1, -3, 3, 3);
                questionNumber++;
                break;
            case 4:
                GamesCategoryPointsHelper.AddPoints(-1, 5, -2, 4, -5, -5, 4, -5, 2);
                questionNumber++;
                break;
            case 5:
                GamesCategoryPointsHelper.AddPoints(4, 5, 5,5, 3,4,2,5,1);
                questionNumber++;
                break;
            case 6:
                GamesCategoryPointsHelper.AddPoints(3,-2,3,-3,5,3,0,5,0);
                questionNumber++;
                break;
            case 7:
                GamesCategoryPointsHelper.AddPoints(1,-3,5,1,3,4,-3,4,0);
                questionNumber++;
                break;
            case 8:
                GamesCategoryPointsHelper.AddPoints(0,0,5,4,2,4,0,2,2);
                questionNumber++;
                break;
            case 9:
                GamesCategoryPointsHelper.AddPoints(5,5,-5,-3,-2,-4,5,-2,4);
                questionNumber++;
                break;
            case 10:
                GamesCategoryPointsHelper.AddPoints(3,-3,-2,-5,5,-3,-5,5,4);
                questionNumber++;
                break;
            case 11:
                GamesCategoryPointsHelper.AddPoints(4,5,3,0,5,2,5,4,5);
                questionNumber++;
                break;
            case 12:
                GamesCategoryPointsHelper.AddPoints(-2,-2,5,4,-5,5,2,-5,-2);
                questionNumber++;
                break;
            case 13:
                GamesCategoryPointsHelper.AddPoints(-4,-4,5,4,-5,5,-3,-4,-4);
                questionNumber++;
                break;
            case 14:
                GamesCategoryPointsHelper.AddPoints(-2,0,5,5,-3,5,-3,3,1);
                questionNumber++;
                break;
            case 15:
                GamesCategoryPointsHelper.AddPoints(-3,-4,5,5,0,4,1,3,2);
                questionNumber++;
                break;
            case 16:
                GamesCategoryPointsHelper.GetDebugLogOfMap();
                break;
        }
    }
    
    public void AgreeButton()
    {
        questionNumber++;
    }
    
    public void NeutralButton()
    {
        questionNumber++;
    }
    
    public void DisagreeButton()
    {
        questionNumber++;
    }
    
    public void StrongDisagreeButton()
    {
        questionNumber++;
    }
    
}
