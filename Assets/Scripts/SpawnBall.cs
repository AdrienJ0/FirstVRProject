using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject[] balls;

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
            float angle = Random.Range(0f, 180f);
            float radius = Random.Range(0.3f, 1f);
            ball.transform.position = new Vector3(radius,
                Random.Range(1f, 2f),
                radius);

            yield return new WaitForSeconds(Random.Range(1f, 3f));
        }
    }
}
