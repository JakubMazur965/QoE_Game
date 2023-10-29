using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleLevelMosEngine : MonoBehaviour
{
    public void FiveScore()
    {
        DataToDbdto.LvlPuzzleMos = 5;
        GamesCategoryPointsHelper.AddPoints(3,3,0,0,3,0,5,4,4);
        SceneManager.LoadScene("Summary");
    }
    
    public void FourScore()
    {
        DataToDbdto.LvlPuzzleMos = 4;
        GamesCategoryPointsHelper.AddPoints(2,2,1,1,2,1,3,2,2);
        SceneManager.LoadScene("Summary");
    }
    
    public void ThreeScore()
    {
        DataToDbdto.LvlPuzzleMos = 3;
        GamesCategoryPointsHelper.AddPoints(1,1,2,2,1,2,0,0,0);
        SceneManager.LoadScene("Summary");
    }
    
    public void TwoScore()
    {
        DataToDbdto.LvlPuzzleMos = 2;
        GamesCategoryPointsHelper.AddPoints(-1,-1,3,3,-1,3,-3,-2,-2);
        SceneManager.LoadScene("Summary");
    }
    
    public void OneScore()
    {
        DataToDbdto.LvlPuzzleMos = 1;
        GamesCategoryPointsHelper.AddPoints(-3,-3,4,4,-3,4,-5,-4,-4);
        SceneManager.LoadScene("Summary");
    }
}
