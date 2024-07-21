using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuPanelScript : MonoBehaviour
{
    public GameObject PausePanel;
    private BackgroundScript backgroundScript;
    private BoxCollider2D backgroundBoxCollider;

    public void Awake()
    {
        backgroundScript = GameObject.FindGameObjectWithTag("Background").GetComponent<BackgroundScript>();
        backgroundBoxCollider = GameObject.FindGameObjectWithTag("Background").GetComponent<BoxCollider2D>();
    }

    public void PauseGame()
    {
        PausePanel.SetActive(true);
        backgroundScript.enabled = false;
        backgroundBoxCollider.enabled = false;
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        backgroundScript.enabled = true;
        backgroundBoxCollider.enabled = true;
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
