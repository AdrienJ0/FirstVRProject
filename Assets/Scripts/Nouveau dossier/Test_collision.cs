using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_collision : MonoBehaviour
{
    int compteur;
    [SerializeField] private GameObject gantdes;
    // Start is called before the first frame update
    void Start()
    {
        compteur = 0;
    }

    // Update is called once per frame
   
    void OnCollisionEnter(Collision gantdes)
    {
        if (gantdes.gameObject.layer == LayerMask.NameToLayer("Glove"))
        {
            compteur = compteur + 1;
            Debug.Log("boss");
            Debug.Log(compteur);
        }
       
    }

}
