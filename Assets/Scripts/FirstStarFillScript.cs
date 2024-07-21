using UnityEngine;
using UnityEngine.UI;

public class FirstStarFill : MonoBehaviour
{
    public GameObject StarFill;
    public GameObject StarOutline;
    public Scrollbar scrollbar;

    void Start()
    {
        StarFill.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (scrollbar.size >= 0.244f)
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
