using UnityEngine;
using UnityEngine.SceneManagement;

public class ResponseTimeMOSEngine : MonoBehaviour
{
    public void FiveScore()
    {
        DataToDbdto.LvlResponseMos = 5;
        GamesCategoryPointsHelper.AddPoints(1,2,3,5,0,5,5,2,2);
        SceneManager.LoadScene("MemorizingLevel");
    }
    
    public void FourScore()
    {
        DataToDbdto.LvlResponseMos = 4;
        GamesCategoryPointsHelper.AddPoints(1,2,1,3,1,3,4,2,2);
        SceneManager.LoadScene("MemorizingLevel");
    }
    
    public void ThreeScore()
    {
        DataToDbdto.LvlResponseMos = 3;
        GamesCategoryPointsHelper.AddPoints(2,1,0,1,1,1,2,1,1);
        SceneManager.LoadScene("MemorizingLevel");
    }
    
    public void TwoScore()
    {
        DataToDbdto.LvlResponseMos = 2;
        GamesCategoryPointsHelper.AddPoints(2,1,-1,-1,2,-1,1,1,1);
        SceneManager.LoadScene("MemorizingLevel");
    }
    
    public void OneScore()
    {
        DataToDbdto.LvlResponseMos = 1;
        GamesCategoryPointsHelper.AddPoints(3,0,-3,-3,2,-3,-1,0,0);
        SceneManager.LoadScene("MemorizingLevel");
    }
}
