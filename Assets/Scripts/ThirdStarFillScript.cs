using UnityEngine;
using UnityEngine.UI;

public class ThirdStarFill : MonoBehaviour
{
    public GameObject StarFill;
    public Scrollbar scrollbar;
    public GameObject StarOutline;

    void Start()
    {
        StarFill.SetActive(false);
    }

    void Update()
    {
        if (scrollbar.size >= 1f)
        {
            StarFill.SetActive(true);
            StarOutline.SetActive(false);
        }
        else
        {
            StarOutline.SetActive(true);
            StarFill.SetActive(false);
        }
    }
}
