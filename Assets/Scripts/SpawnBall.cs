using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour
{
    public GameObject[] balls;
    public Image[] hearts;
    public Sprite emptyHeart;
    private float spawnSpeed = 3f;
    private float speedLimit = 0.8f;
    private float speedDecrement = 0.05f;
    //private int nbMiss = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBallOverTime());
    }

    IEnumerator SpawnBallOverTime()
    {
        while (true)
        {
            GameObject ball = Instantiate(balls[Random.Range(0, balls.Length)]);
            float angle = Random.Range(60f, 120f);
            float radius = 1f;
            ball.transform.position = new Vector3(Mathf.Cos(angle),
                Random.Range(1.4f,2f),
                radius);
            if (spawnSpeed >  speedLimit)
                spawnSpeed -= speedDecrement;

            yield return new WaitForSeconds(spawnSpeed);

            if(ball != null)
            {
                Debug.Log("Miss");
                //Debug.Log(PlayerInfos.getNbMiss());
                Destroy(ball);
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
            //Debug.Log(spawnSpeed);
        }
    }
}
