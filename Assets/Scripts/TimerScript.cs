using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class TimerScript : MonoBehaviour
{

    private float time;
    private float timeMax = 30;
    public float TimerInterval;
    private float tick;
    [SerializeField] private TextMeshProUGUI timerText;

    public GameObject scoreCanvas;
    public GameObject timeOverPanel;
    public GameObject endScorePanel;

    public GameObject punchingBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = (float)Time.time;
        if (timeMax - time > 0)
        {
            timerText.text = string.Format("{0:0.00}", timeMax - time);
            
        }
        if(timeMax - time <= 0)
        {
            Destroy(punchingBall);
            timerText.text = "0.00";
            ShowTimeOut();
            ShowEndScore();
        
            //RetourMainMenu();
        }

        
    }

    void ShowTimeOut()
    {
        scoreCanvas.SetActive(false);
        timeOverPanel.SetActive(true);
        //Time.timeScale = 0;
        //yield return new WaitForSeconds(2f);
    }

    void ShowEndScore()
    {
        //Time.timeScale = 0;
        timeOverPanel.SetActive(false);
        endScorePanel.SetActive(true);
    }

    void RetourMainMenu()
    {
         SceneManager.LoadScene("UI");
        
    }

}
