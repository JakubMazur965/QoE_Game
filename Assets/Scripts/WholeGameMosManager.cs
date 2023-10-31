using UnityEngine;
using UnityEngine.SceneManagement;

public class WholeGameMosManager : MonoBehaviour
{
    public void FiveScore()
    {
        DataToDbdto.WholeGameMos = 5;
        DBHelper.SaveAllDataToDB();
        SceneManager.LoadScene("TheEnd");
    }
    
    public void FourScore()
    {
        DataToDbdto.WholeGameMos = 4;
        DBHelper.SaveAllDataToDB();
        SceneManager.LoadScene("TheEnd");
    }
    
    public void ThreeScore()
    {
        DataToDbdto.WholeGameMos = 3;
        DBHelper.SaveAllDataToDB();
        SceneManager.LoadScene("TheEnd");
    }
    
    public void TwoScore()
    {
        DataToDbdto.WholeGameMos = 2;
        DBHelper.SaveAllDataToDB();
        SceneManager.LoadScene("TheEnd");
    }
    
    public void OneScore()
    {
        DataToDbdto.WholeGameMos = 1;
        DBHelper.SaveAllDataToDB();
        SceneManager.LoadScene("TheEnd");
    }
}
