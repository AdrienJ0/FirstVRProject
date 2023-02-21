using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour
{
    public GameObject[] balls;
    public Image[] hearts;
    public Sprite emptyHeart;
    private float spawnSpeed = 1.5f;
    private float speedLimit = 0.8f;
    private float speedDecrement = 0.01f;
    private int nbMiss = 0;

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
            float angle = Random.Range(20f, 160f);
            float radius = 1f;
            ball.transform.position = new Vector3(Mathf.Cos(angle),
                Random.Range(1.4f,2f),
                radius);
            if (spawnSpeed >  speedLimit)
                spawnSpeed -= speedDecrement;

            yield return new WaitForSeconds(spawnSpeed);
            if(ball != null)
            {
                Destroy(ball);
                Debug.Log("Raté");
                Debug.Log(PlayerInfos.getNbHearts());

                if (PlayerInfos.getNbHearts() > 1)
                {
                    hearts[nbMiss].sprite = emptyHeart;
                    PlayerInfos.removeOneHeart();
                    nbMiss++;
                }
                else if(PlayerInfos.getNbHearts() == 1)
                {
                    hearts[nbMiss].sprite = emptyHeart;
                    PlayerInfos.removeOneHeart();
                    Debug.Log("Game Over!");
                    nbMiss++;
                }
            }

            if(ball == null)
            {
                Debug.Log("Réussi");
                PlayerInfos.addNbPoints(5);
            }
            
            //Debug.Log(spawnSpeed);
        }
    }
}
