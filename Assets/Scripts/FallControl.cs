using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FallControl : MonoBehaviour
{
    public float acc = 0;
    public GameObject player;
    private int lastY = 0;

    void OnTriggerStay(Collider myTrigger)
    {
        if (myTrigger.gameObject.tag == "Enemy")
        {
            Debug.Log(myTrigger.gameObject.name + " went through!");
            myTrigger.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            myTrigger.gameObject.transform.Translate(0, -34f * Time.deltaTime, 0);
        }

        /*
        if (myTrigger.gameObject.tag == "Player")
        {
            Debug.Log("Player in");
            player.transform.position -= Vector3.up * 30 * Time.deltaTime;
        }*/
        /*
        if (myTrigger.gameObject.tag == "Player")
        {
            Debug.Log("Player went through!");
            myTrigger.attachedRigidbody.detectCollisions = false;
            myTrigger.attachedRigidbody.isKinematic = true;
            myTrigger.gameObject.transform.Translate(0, -0.8f, 0);


        }*/
    }
    


}
