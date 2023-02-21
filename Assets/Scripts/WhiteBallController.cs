using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBallController : MonoBehaviour
{
    private Rigidbody cibleRigidbody;
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
            Destroy(gameObject);
            PlayerInfos.addNbPoints(5);
            Debug.Log("Hit white ball");
            //GetComponent<AudioSource>().PlayOneShot(sonKill);
            //Instantiate(killEffect, cibleTransform.position, killEffect.transform.rotation); //Génère des particules de sang
        }


    }
}
