using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallSceneManager : MonoBehaviour
{
    public GameObject[] balls;
    public Image[] hearts;
    public Sprite emptyHeart;
    private float spawnSpeed = 3f;
    private float speedLimit = 0.8f;
    private float speedDecrement = 0.05f;
    private int random;

    public GameObject scoreCanvas;
    public GameObject gameOverPanel;
    public GameObject endScorePanel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBallOverTime());
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfos.getNbHearts() == 0)
        {
            //StopCoroutine(SpawnBallOverTime());
            ShowGameOver();
            //yield return new WaitForSeconds(2f);
            ShowEndScore();
        }
    }

    void ShowGameOver()
    {
        scoreCanvas.SetActive(false);
        gameOverPanel.SetActive(true);
        //Time.timeScale = 0;
        //yield return new WaitForSeconds(2f);
    }

    void ShowEndScore()
    {
        //Time.timeScale = 0;
        gameOverPanel.SetActive(false);
        endScorePanel.SetActive(true);
    }

    //private int nbMiss = 0;

    // Start is called before the first frame update
    
    IEnumerator SpawnBallOverTime()
    {
        while (PlayerInfos.getNbHearts() != 0)
        {
            random = Random.Range(0, balls.Length);
            if (random == 0)
            {
                GameObject ballWhite = Instantiate(balls[0]);
                float angle = Random.Range(60f, 120f);
                float radius = 1f;
                ballWhite.transform.position = new Vector3(Mathf.Cos(angle),
                    Random.Range(1.4f, 2f),
                    radius);
                if (spawnSpeed > speedLimit)
                    spawnSpeed -= speedDecrement;

                yield return new WaitForSeconds(spawnSpeed);

                if (ballWhite != null)
                {
                    Debug.Log("Miss");
                    //Debug.Log(PlayerInfos.getNbMiss());
                    Destroy(ballWhite);
                    Debug.Log(PlayerInfos.getNbHearts());

                    if (PlayerInfos.getNbHearts() >= 1 && PlayerInfos.getNbMiss() < 3)
                    {
                        PlayerInfos.removeOneHeart();
                        PlayerInfos.incrementNbMiss();
                        if (PlayerInfos.getNbHearts() == 1)
                        {
                            Debug.Log("Game Over!");
                        }
                    }
                }
            }
            else if (random == 1)
            {
                GameObject ballRed = Instantiate(balls[1]);
                float angle = Random.Range(60f, 120f);
                float radius = 1f;
                ballRed.transform.position = new Vector3(Mathf.Cos(angle),
                    Random.Range(1.4f, 2f),
                    radius);
                if (spawnSpeed > speedLimit)
                    spawnSpeed -= speedDecrement;

                yield return new WaitForSeconds(spawnSpeed);
                if (ballRed != null)
                {
                    Destroy(ballRed);
                }
            }

        }
    }
}
