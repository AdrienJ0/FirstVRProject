using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Changement_scene : MonoBehaviour
{
    [SerializeField] private GameObject perso1;
    [SerializeField] private GameObject perso2;
    [SerializeField] private GameObject perso3;
    [SerializeField] private GameObject perso4;
    [SerializeField] private GameObject perso5;
    [SerializeField] private GameObject perso6;
    int Changement;

    //GameObject precedent = new GameObject();
    GameObject clone;
    // Start is called before the first frame update
    void Start()
    {

        Changement = 0;

    }

    // Update is called once per frame

    public void GererClic()
    {
        Changement = Changement + 1;

        if (Changement == 1)
        {
            Destroy(clone);
            clone = Instantiate(perso1, new Vector3(0f, 2f, 0f),
               Quaternion.identity);

        }
        else if (Changement == 2)
        {
            Destroy(clone);
            clone = Instantiate(perso2, new Vector3(0f, 2f, 0f),
              Quaternion.identity);



        }
        else if (Changement == 3)
        {
            Destroy(clone);
            clone = Instantiate(perso3, new Vector3(0f, 2f, 0f),
              Quaternion.identity);




        }
        else if (Changement == 4)
        {
            Destroy(clone);
            clone = Instantiate(perso4, new Vector3(0f, 2f, 0f),
              Quaternion.identity);

            Changement = 0;


        }
        else if (Changement == 5)
        {
            Destroy(clone);
            clone = Instantiate(perso5, new Vector3(0f, 2f, 0f),
              Quaternion.identity);

            Changement = 0;


        }
        else if (Changement == 6)
        {
            Destroy(clone);
            clone = Instantiate(perso6, new Vector3(0f, 2f, 0f),
              Quaternion.identity);

            Changement = 0;


        }
    }


}
