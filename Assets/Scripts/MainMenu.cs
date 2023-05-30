using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuBtn;
    public GameObject stagePanel;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StagePanel()
    {
        mainMenuBtn.SetActive(false);
        stagePanel.SetActive(true);
    }
    public void Stage1()
    {
        SceneManager.LoadScene("Stage 1");
    }
    
    public void Stage2()
    {
        SceneManager.LoadScene("Stage 2");
    }
    
    public void Stage3()
    {
        SceneManager.LoadScene("Stage 3");
    }

    public void MainMenuBtn()
    {
        stagePanel.SetActive(false);
        mainMenuBtn.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
