using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;

public class PunchHand : MonoBehaviour
{

    //public XRController hand; //type XR à modifier
    private Rigidbody rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponentInChildren<Rigidbody>();
    }

    //Update is called once per frame
    void Update()
    {
        rBody.MovePosition(transform.position);
        rBody.MoveRotation(transform.rotation);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if (collision == null)
            return;

        Rigidbody collisionR = collision.gameObject.GetComponentInChildren<Rigidbody>();

        Vector3 avgPoint = Vector3.zero;
        foreach (ContactPoint p in collision.contacts)
        {
            avgPoint += p.point;
        }


        avgPoint /= collision.contacts.Length;

        Vector3 dir = (avgPoint - rBody.transform.position).normalized;
        collisionR.AddForceAtPosition(dir * 10f * rBody.velocity.magnitude, avgPoint);

        StartCoroutine(LongVibration(.1f, .2f));

    }

    IEnumerator LongVibration(float length, float strength)
    {
        for(float i = 0; i < length;  i+= Time.deltaTime)
        {
            //OpenXRInput.SendHapticImpulse(hapticAction.action, _amplitude, _frequency, _duration, control.device);
            yield return null;
        }
    }
}
