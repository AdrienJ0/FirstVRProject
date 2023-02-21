using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;

    // Update is called once per frame
    void Update()
    {
        GestionScore();
    }

    public void GestionScore()
    {
        textComponent.text = "" + PlayerInfos.getNbPoints();
    }

    
}
