using UnityEngine;
using UnityEngine.UI;

public class SecondStarOutline : MonoBehaviour
{
    public GameObject StarOutline;
    public GameObject StarFill;
    public Scrollbar scrollbar;

    void Update()
    {
        if (scrollbar.size < 0.742f)
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
