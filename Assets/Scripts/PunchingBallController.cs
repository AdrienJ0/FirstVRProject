using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingBallController : MonoBehaviour
{
    //private Rigidbody cibleRigidbody;
    //[SerializeField] private Transform punchingBallTransform;
    private static LayerMask gloveLayer;

    private void Awake()
    {
        gloveLayer = LayerMask.NameToLayer("Glove");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Hit Punching Bag!");
        if (collision.gameObject.layer != gloveLayer)
            return;

        if (collision.gameObject.layer == gloveLayer)
        {
            PlayerInfos.addNbPoints(100);
            Debug.Log("Hit punching ball");
            //GetComponent<AudioSource>().PlayOneShot(sonKill);
            //Instantiate(killEffect, cibleTransform.position, killEffect.transform.rotation); //Génère des particules de sang
        }
    }
}
