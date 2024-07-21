using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScenePanelActionsScript : MonoBehaviour
{
    private BackgroundScript backgroundScript;
    private BoxCollider2D backgroundBoxCollider;

    public void Awake()
    {
        Time.timeScale = 0;
        backgroundScript = GameObject.FindGameObjectWithTag("Background").GetComponent<BackgroundScript>();
        backgroundBoxCollider = GameObject.FindGameObjectWithTag("Background").GetComponent<BoxCollider2D>();
        backgroundScript.enabled = false;
        backgroundBoxCollider.enabled = false;
    }

    public void NextScene()
    {
        backgroundScript.enabled = true;
        backgroundBoxCollider.enabled = true;
        SceneManager.LoadScene("Level 2");
        Time.timeScale = 1;
    }

    public void Home()
    {
        backgroundScript.enabled = true;
        backgroundBoxCollider.enabled = true;
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        backgroundScript.enabled = true;
        backgroundBoxCollider.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
