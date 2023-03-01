using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class slider_gestion : MonoBehaviour
{
    [SerializeField] private Slider point_vie_perso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision perso)
    {
        if (perso.gameObject.layer == LayerMask.NameToLayer("Glove"))
        {
            
            point_vie_perso.value = point_vie_perso.value + 10;
        }
        else
        {

        }

    }
}
