using UnityEngine;
using UnityEngine.SceneManagement;

public class MemorizingLevelMosEngine : MonoBehaviour
{
    public void FiveScore()
    {
        DataToDbdto.LvlMemorizingMos = 5;
        GamesCategoryPointsHelper.AddPoints(4,5,0,1,3,0,4,2,0);
        SceneManager.LoadScene("AimLevel");
    }
    
    public void FourScore()
    {
        DataToDbdto.LvlMemorizingMos = 4;
        GamesCategoryPointsHelper.AddPoints(3,3,1,1,2,1,2,1,1);
        SceneManager.LoadScene("AimLevel");
    }
    
    public void ThreeScore()
    {
        DataToDbdto.LvlMemorizingMos = 3;
        GamesCategoryPointsHelper.AddPoints(1,1,2,2,1,2,1,0,2);
        SceneManager.LoadScene("AimLevel");
    }
    
    public void TwoScore()
    {
        DataToDbdto.LvlMemorizingMos = 2;
        GamesCategoryPointsHelper.AddPoints(-1,-1,3,2,-1,3,0,0,3);
        SceneManager.LoadScene("AimLevel");
    }
    
    public void OneScore()
    {
        DataToDbdto.LvlMemorizingMos = 1;
        GamesCategoryPointsHelper.AddPoints(-3,-3,4,3,-2,4,-1,-1,4);
        SceneManager.LoadScene("AimLevel");
    }
}
