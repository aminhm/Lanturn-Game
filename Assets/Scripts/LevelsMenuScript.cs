using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsMenuScript : MonoBehaviour
{
    public Sprite FirstLevelFullSprite;
    public Sprite SecondLevelFullSprite;
    private void Start()
    {
        int firstLevelScore = PlayerPrefs.GetInt("score1");
        int secondLevelScore = PlayerPrefs.GetInt("score2");
        if (firstLevelScore != 0)
        {
            if (firstLevelScore >= 1)
            {
                Image component = transform.GetChild(2).GetChild(1).GetComponent<Image>();
                component.sprite = FirstLevelFullSprite;
                component.color = new Color(255,255,255,255);
            }
            if (firstLevelScore >= 2)
            {
                Image component = transform.GetChild(2).GetChild(2).GetComponent<Image>();
                component.sprite = FirstLevelFullSprite;
                component.color = new Color(255, 255, 255, 255);
            }
            if (firstLevelScore == 3)
            {
                Image component = transform.GetChild(2).GetChild(3).GetComponent<Image>();
                component.sprite = FirstLevelFullSprite;
                component.color = new Color(255, 255, 255, 255);
            }
        }
        if (secondLevelScore != 0)
        {
            if (secondLevelScore >= 1)
            {
                Image component = transform.GetChild(3).GetChild(1).GetComponent<Image>();
                component.sprite = SecondLevelFullSprite;
                component.color = new Color(255, 255, 255, 255);
            }
            if (secondLevelScore >= 2)
            {
                Image component = transform.GetChild(3).GetChild(2).GetComponent<Image>();
                component.sprite = SecondLevelFullSprite;
                component.color = new Color(255, 255, 255, 255);
            }
            if (secondLevelScore == 3)
            {
                Image component = transform.GetChild(3).GetChild(3).GetComponent<Image>();
                component.sprite = SecondLevelFullSprite;
                component.color = new Color(255, 255, 255, 255);
            }
        }
    }
    public void PlayLevel1()
    {
        SceneManager.LoadScene("level 1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("level 2");
    }

}
