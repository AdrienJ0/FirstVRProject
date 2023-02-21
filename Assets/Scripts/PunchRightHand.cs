using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;
using UnityEngine.InputSystem;

public class PunchRightHand : MonoBehaviour
{

    //public XRController hand; //type XR à modifier
    private Rigidbody rBody;
    [SerializeField] InputActionReference rightHapticAction;
    private float amplitude;
    private float duration;

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

        OpenXRInput.SendHapticImpulse(rightHapticAction, amplitude, duration, UnityEngine.InputSystem.XR.XRController.rightHand); //Right Hand Haptic Impulse

    }

    
}
