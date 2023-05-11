using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    // bool upForce;
    // bool downForce;
    // bool leftForce;
    // bool rightForce;

    void OnEnable()
    {
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(upForce)
        // {
        //     rb.AddForce(Vector3.forward * 1f);
        // }
        // if(downForce)
        // {
        //     rb.AddForce(Vector3.back * 1f);
        // }
        // if(leftForce)
        // {
        //     rb.AddForce(Vector3.left * 1f);
        // }
        // if(rightForce)
        // {
        //     rb.AddForce(Vector3.right * 1f);
        // }

        if(rb.velocity.magnitude >= 20f)
        {
            // upForce = false;
            // downForce = false;
            // leftForce = false;
            // rightForce = false;
            rb.velocity = rb.velocity.normalized * 20f;
        }
    }

    public void UpForce()
    {
        // upForce = true;
        // downForce = false;
        // leftForce = false;
        // rightForce = false;
        rb.AddForce(Vector3.forward * 5f);
    }

    public void DownForce()
    {
        // downForce = true;
        // upForce = false;
        // leftForce = false;
        // rightForce = false;
        rb.AddForce(Vector3.back * 5f);
    }

    public void LeftForce()
    {
        // leftForce = true;
        // upForce = false;
        // downForce = false;
        // rightForce = false;
        rb.AddForce(Vector3.left * 5f);
    }

    public void RightForce()
    {
        // rightForce = true;
        // upForce = false;
        // downForce = false;
        // leftForce = false;
        rb.AddForce(Vector3.right * 5f);
    }
}
