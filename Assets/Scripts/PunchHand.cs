using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchHand : MonoBehaviour
{

    //public XRController hand; //type XR � modifier
    private Rigidbody rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    rBody.MovePosition(hand.transform.position);
    //    rBody.MoveRotation(hand.transform.rotation);
    //}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if (collision == null)
            return;

        Rigidbody collisionR = collision.gameObject.GetComponentInChildren<Rigidbody>();

        Vector3 avgPoint = Vector3.zero;
        foreach (ContactPoint p in collision.contacts)
        {
            avgPoint += p.points;
        }


        avgPoint /= collision.contacts.Length;

        Vector3 dir = (avgPoint - transform.position).normalized;
        collisionR.AddForceAtPosition(dir * 10f * rBody.velocity.magnitude, avgPoint);

        StartCorountine(LongVibration(.1f, .2f));

    }

    IEnumerator LongVibration(float length, float strength)
    {
        for(float i = 0; i < length;  i+= Time.deltaTime)
        {
            //SteamVR_Controller.Input(hand.index).TriggerHapticPulse((ushort)Mathf.Lerp(0, 3999, strength));
            yield return null;
        }
    }
}
