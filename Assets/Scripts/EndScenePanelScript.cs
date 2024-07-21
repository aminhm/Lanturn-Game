using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScenePanelScript : MonoBehaviour
{
    public Scrollbar scrollbar;
    public Sprite LanternFullSprite;
    private GameObject GamePassed;
    private GameObject GameOver;
    private GameObject Lanterns;
    private void Awake()
    {
        GamePassed = transform.GetChild(0).gameObject;
        GameOver = transform.GetChild(1).gameObject;
        Lanterns = transform.GetChild(2).gameObject;
        if (scrollbar.size < 0.244f)
        {
            GameOver.SetActive(true);
        }
        else
        {
            GamePassed.SetActive(true);
        }
        Lanterns.SetActive(true);
        string levelNumber = SceneManager.GetActiveScene().name.Split(" ")[1];
        if (scrollbar.size >= 0.244f)
        {

            Lanterns.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LanternFullSprite;
            PlayerPrefs.SetInt(
                "score" + levelNumber
                , PlayerPrefs.GetInt("score" + levelNumber) < 1 ? 1 :
                PlayerPrefs.GetInt("score" + levelNumber));
        }
        if (scrollbar.size >= 0.742f)
        {
            Lanterns.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = LanternFullSprite;
            PlayerPrefs.SetInt(
                "score" + levelNumber
                , PlayerPrefs.GetInt("score" + levelNumber) < 2 ? 2 :
                PlayerPrefs.GetInt("score" + levelNumber));
        }
        if (scrollbar.size >= 1f)
        {
            Lanterns.transform.GetChild(2).gameObject.GetComponent<Image>().sprite = LanternFullSprite;
            PlayerPrefs.SetInt(
                "score" + levelNumber
                , 3);
        }
    }
}
