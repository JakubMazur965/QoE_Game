using UnityEngine;
using UnityEngine.SceneManagement;

public class RecommendationMosEngine : MonoBehaviour
{
    public void FiveScore()
    {
        DataToDbdto.SystemRecommendationMos = 5;
        SceneManager.LoadScene("WholeGameMos");
    }
    
    public void FourScore()
    {
        DataToDbdto.SystemRecommendationMos = 4;
        SceneManager.LoadScene("WholeGameMos");
    }
    
    public void ThreeScore()
    {
        DataToDbdto.SystemRecommendationMos = 3;
        SceneManager.LoadScene("WholeGameMos");
    }
    
    public void TwoScore()
    {
        DataToDbdto.SystemRecommendationMos = 2;
        SceneManager.LoadScene("WholeGameMos");
    }
    
    public void OneScore()
    {
        DataToDbdto.SystemRecommendationMos = 1;
        SceneManager.LoadScene("WholeGameMos");
    }
}