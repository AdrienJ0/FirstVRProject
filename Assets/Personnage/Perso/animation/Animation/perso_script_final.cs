using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class perso_script_final : MonoBehaviour
{

    Animator anime;
    int compteur;
    [SerializeField] private GameObject gantdes;
   
    void Start()
    {
        anime = gameObject.GetComponent<Animator>();
        compteur = 0;
       
    }

    void Update()
    {
        clic();
        
    }

    void OnCollisionEnter(Collision perso)
    {
        if (perso.gameObject.layer == LayerMask.NameToLayer("Glove"))
        {
            compteur = compteur + 1;
            
        }
        else
        {

        }
        
    }

    void clic()

    {
        if (compteur > 0)
        {
            if (compteur % 2 != 0)
            {
                anime.SetBool("transit", true);
            }
            else if (compteur % 2 == 0)
            {

                anime.SetBool("transit", false);
            }
            else { }
        }
        else { }
    }
}