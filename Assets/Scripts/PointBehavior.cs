using UnityEngine;
using UnityEngine.UI;

public class PointBehavior : MonoBehaviour
{
    public Image redPointImage;
    private void Start()
    {
        redPointImage.GetComponent<Button>().onClick.AddListener(OnClickPoint);
    }
    public void OnClickPoint()
    {
        AimLevelEngine.PointsShot++;
        Destroy(redPointImage.gameObject);
    }
}
