using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class test_1 : MonoBehaviour
{

    Animator anime;
    int compteur;
    [SerializeField] private Slider point_money2;
    void Start()
    {
        anime = gameObject.GetComponent<Animator>();
        compteur = 0;
        point_money2.value = 0;

    }

    void Update()
    {
        cli();
        clic();

    }
    void cli()
    {
        if (Input.GetButtonDown("Jump"))
        {
            compteur = compteur + 1;
            Debug.Log("azerty");
            point_money2.value = point_money2.value + 1;
            Debug.Log(point_money2.value);
        }
    }
  


    void clic()

    {
        if (compteur % 2 !=0)
        {
            Debug.Log(compteur);

            anime.SetBool("transit", true);
        }
        else if (compteur % 2 ==0)
        {
            Debug.Log(compteur);

            anime.SetBool("transit", false);
        }
    }





}
