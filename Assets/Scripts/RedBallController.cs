using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallController : MonoBehaviour
{
    private Rigidbody cibleRigidbody;
    [SerializeField] private Transform cibleTransform;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.layer == ballLayer)
        //{
        //GetComponent<AudioSource>().PlayOneShot(sonKill);
        //Instantiate(killEffect, cibleTransform.position, killEffect.transform.rotation); //G�n�re des particules de sang
        //Destroy(gameObject);

        //Player.removeHeart();
        //Debug.Log("Bien jou�! +5 points!");
        //Debug.Log(Player.getNbPoints());
        //}

        Destroy(gameObject);

    }
}
