using UnityEngine;
using UnityEngine.SceneManagement;

public class AimLevelMosEngine : MonoBehaviour
{
    public void FiveScore()
    {
        DataToDbdto.LvlAimMos = 5;
        GamesCategoryPointsHelper.AddPoints(-2,0,5,3,-2,3,0,4,-2);
        SceneManager.LoadScene("PuzzleLevel");
    }
    
    public void FourScore()
    {
        DataToDbdto.LvlAimMos = 4;
        GamesCategoryPointsHelper.AddPoints(-1,1,3,1,-1,2,1,2,-1);
        SceneManager.LoadScene("PuzzleLevel");
    }
    
    public void ThreeScore()
    {
        DataToDbdto.LvlAimMos = 3;
        GamesCategoryPointsHelper.AddPoints(0,1,0,0,0,1,1,1,0);
        SceneManager.LoadScene("PuzzleLevel");
    }
    
    public void TwoScore()
    {
        DataToDbdto.LvlAimMos = 2;
        GamesCategoryPointsHelper.AddPoints(2,2,-3,-1,2,0,2,0,2);
        SceneManager.LoadScene("PuzzleLevel");
    }
    
    public void OneScore()
    {
        DataToDbdto.LvlAimMos = 1;
        GamesCategoryPointsHelper.AddPoints(3,2,-5,-3,3,-1,2,-1,3);
        SceneManager.LoadScene("PuzzleLevel");
    }
}
