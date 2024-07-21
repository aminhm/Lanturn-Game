using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float time = 60;
    public Text TimeText;
    public GameObject EndScene;

    void Start()
    {
        updateTimeText();
    }

    void Update()
    {
        updateTimeText();
    }

    void updateTimeText()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            TimeText.text = ((int)time).ToString();
        }
        else
        {
            EndScene.SetActive(true);
        }
    }
}
