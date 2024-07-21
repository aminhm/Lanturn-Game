using UnityEngine;
using UnityEngine.UI;

public class ThirdStarOutline : MonoBehaviour
{
    public GameObject StarOutline;
    public Scrollbar scrollbar;
    public GameObject StarFill;

    void Update()
    {
        if (scrollbar.size < 1f)
        {
            StarOutline.SetActive(true);
            StarFill.SetActive(false);
        }
        else
        {
            StarFill.SetActive(true);
            StarOutline.SetActive(false);
        }
    }
}
