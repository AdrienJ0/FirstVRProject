using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingBallController : MonoBehaviour
{
    //private Rigidbody cibleRigidbody;
    [SerializeField] private Transform punchingBallTransform;

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
        Debug.Log("Hit Punching Bag!");
        if (collision == null)
            return;

    //    if (other.gameObject.layer == ballLayer)
        //{
            //GetComponent<AudioSource>().PlayOneShot(sonKill);
            //Instantiate(killEffect, punchingBallTransform.position, killEffect.transform.rotation); //Génère des particules de sang
            

            //Player.addNbPoints(5);
            //Debug.Log("Bien joué! +5 points!");
            //Debug.Log(Player.getNbPoints());
    //    }
    }
}
