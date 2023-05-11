using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;

    void OnEnable()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude >= 10f)
        {
            rb.velocity = rb.velocity.normalized * 10f;
        }
    }

    public void UpForce()
    {
        rb.AddRelativeForce(Vector3.forward * 5f);
    }

    public void DownForce()
    {
        rb.AddRelativeForce(Vector3.back * 5f);
    }

    public void LeftForce()
    {
        rb.AddRelativeForce(Vector3.left * 5f);
    }

    public void RightForce()
    {
        rb.AddRelativeForce(Vector3.right * 5f);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "GameEnd")
        {
            // Debug.Log("Game Over");
            GameController.game.ShowUI();
        }
    }
}
