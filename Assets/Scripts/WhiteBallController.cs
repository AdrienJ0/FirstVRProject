using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBallController : MonoBehaviour
{
    private Rigidbody cibleRigidbody;
    [SerializeField] private Transform cibleTransform;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.layer == ballLayer)
        //{
            //GetComponent<AudioSource>().PlayOneShot(sonKill);
            //Instantiate(killEffect, cibleTransform.position, killEffect.transform.rotation); //Génère des particules de sang
            //Destroy(gameObject);

        //Player.addNbPoints(5);
        //Debug.Log("Bien joué! +5 points!");
        //Debug.Log(Player.getNbPoints());
        //}
        Destroy(gameObject);

    }
}
