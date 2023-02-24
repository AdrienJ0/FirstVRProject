using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSceneManager : MonoBehaviour
{
    public GameObject scoreCanvas;
    public GameObject gameOverPanel;
    public GameObject endScorePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfos.getNbHearts() == 0)
        {
            ShowGameOver();
            //yield return new WaitForSeconds(2f);
            ShowEndScore();
        }
    }

    void ShowGameOver()
    {
        scoreCanvas.SetActive(false);
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        //yield return new WaitForSeconds(2f);
    }

    void ShowEndScore()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(false);
        endScorePanel.SetActive(true);
    }
}
