using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScoreManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite emptyHeart;
    private int nbMiss;

    // Update is called once per frame
    void Update()
    {
        GestionHeart();
    }

    public void GestionHeart()
    {
        nbMiss = PlayerInfos.getNbMiss();
        //Debug.Log(nbMiss);
        if (nbMiss > 0)
        {
            hearts[nbMiss - 1].sprite = emptyHeart;
        }
    }
}
