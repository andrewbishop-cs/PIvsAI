using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject player;

    private float lastY = 0;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        /*
        if ( player.transform.position.y != lastY )
        {
            lastY = player.transform.position.y;
            player.transform.position -= Vector3.up * 30 * Time.deltaTime;

        }*/

        if (player.transform.position.y <= -50)
        {
            Destroy(gameObject);

        }
    }
}
