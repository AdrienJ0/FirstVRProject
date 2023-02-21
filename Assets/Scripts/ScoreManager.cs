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
        GestionTexte();
    }

    public void GestionTexte()
    {
        textComponent.text = "" + PlayerInfos.getNbPoints();
    }
}
