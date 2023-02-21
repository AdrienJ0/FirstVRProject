using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{

    private float time;
    private float timeMax = 30;
    public float TimerInterval;
    private float tick;
    [SerializeField] private TextMeshProUGUI textComponent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = string.Format("{0:0.00}", timeMax-time);
        time = (float )Time.time;
    }
}
