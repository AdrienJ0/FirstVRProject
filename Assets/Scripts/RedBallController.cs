using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallController : MonoBehaviour
{
   // private Rigidbody cibleRigidbody;
    //[SerializeField] private Transform cibleTransform;
    private static LayerMask gloveLayer;
    // Start is called before the first frame update

    private void Awake()
    {
        gloveLayer = LayerMask.NameToLayer("Glove");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == gloveLayer)
        {
            Debug.Log("Miss");
            Destroy(gameObject);
            if (PlayerInfos.getNbHearts() >= 1 && PlayerInfos.getNbMiss() < 3)
            {
                PlayerInfos.removeOneHeart();
                PlayerInfos.incrementNbMiss();
                if (PlayerInfos.getNbHearts() == 1)
                {
                    Debug.Log("Game Over!");
                }
            }
            //GetComponent<AudioSource>().PlayOneShot(sonKill);
            //Instantiate(killEffect, cibleTransform.position, killEffect.transform.rotation); //Génère des particules de sang
        }
    }
}
