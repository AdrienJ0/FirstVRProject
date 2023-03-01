using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class perso_script : MonoBehaviour
{

    Animator anime;
    int compteur;
    [SerializeField] private GameObject gantdes;
    [SerializeField] private Slider point_vie_perso;
    void Start()
    {
        anime = gameObject.GetComponent<Animator>();
        compteur = 0;
        point_vie_perso.value = 0;
    }

    void Update()
    {
        clic();
        
    }

    void OnCollisionEnter(Collision perso)
    {
        if (perso.gameObject.layer == LayerMask.NameToLayer("gant"))
        {
            compteur = compteur + 1;
            point_vie_perso.value = point_vie_perso.value + 1;
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