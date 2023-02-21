using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PunchRightHand : MonoBehaviour
{

    public ActionBasedController hand; //type XR à modifier
    private Rigidbody rBody;
    [SerializeField] InputActionReference rightHapticAction;
    private float amplitude;
    private float duration;

    private static LayerMask whiteBallLayer;
    private static LayerMask redBallLayer;

    private void Awake()
    {
        whiteBallLayer = LayerMask.NameToLayer("WhiteBall");
        redBallLayer = LayerMask.NameToLayer("RedBall");
    }

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    //Update is called once per frame
    void Update()
    {
        rBody.MovePosition(hand.transform.position);
        rBody.MoveRotation(hand.transform.rotation);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Hit");
        if ((collision.gameObject.layer != whiteBallLayer) && (collision.gameObject.layer != redBallLayer))
        {
            //Debug.Log("Hit nothing");
            return;
        }
            

        //if (collision.gameObject.layer == whiteBallLayer)
        //{
        //    Debug.Log("Hit white ball");
        //    Destroy(collision.gameObject);
        //    PlayerInfos.addNbPoints(5);
        //    OpenXRInput.SendHapticImpulse(rightHapticAction, amplitude, duration, UnityEngine.InputSystem.XR.XRController.rightHand); //Right Hand Haptic Impulse
        //}

        //if (collision.gameObject.layer == redBallLayer)
        //{
        //    Debug.Log("Miss");
        //    Destroy(collision.gameObject);
        //    if (PlayerInfos.getNbHearts() >= 1 && PlayerInfos.getNbMiss() < 3)
        //    {
        //        PlayerInfos.removeOneHeart();
        //        PlayerInfos.incrementNbMiss();
        //        if (PlayerInfos.getNbHearts() == 1)
        //        {
        //            Debug.Log("Game Over!");
        //        }
        //    }
        //    OpenXRInput.SendHapticImpulse(rightHapticAction, amplitude, duration, UnityEngine.InputSystem.XR.XRController.rightHand); //Right Hand Haptic Impulse
        //}

        //else
        //{
        //    return;
        //}

        //Rigidbody collisionR = collision.gameObject.GetComponent<Rigidbody>();

        //Vector3 avgPoint = Vector3.zero;
        //foreach (ContactPoint p in collision.contacts)
        //{
        //avgPoint += p.point;
        //}


        //avgPoint /= collision.contacts.Length;

        //Vector3 dir = (avgPoint - rBody.transform.position).normalized;

        //collisionR.AddForceAtPosition(dir * 10f * rBody.velocity.magnitude, avgPoint);

    }


}
