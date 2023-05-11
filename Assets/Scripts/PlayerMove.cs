using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    bool upForce;
    bool downForce;
    bool leftForce;
    bool rightForce;
    bool buttonPressed;

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
        if(upForce && buttonPressed)
        {
            rb.AddForce(Vector3.forward);
        }
        if(downForce && buttonPressed)
        {
            rb.AddForce(Vector3.back);
        }
        if(leftForce && buttonPressed)
        {
            rb.AddForce(Vector3.left);
        }
        if(rightForce && buttonPressed)
        {
            rb.AddForce(Vector3.right);
        }

        if(rb.velocity.magnitude >= 5f)
        {
            upForce = false;
            downForce = false;
            leftForce = false;
            rightForce = false;
        }
    }

    public void UpForce()
    {
        upForce = true;
        // rb.AddForce(Vector3.forward * 0.5f);
    }

    public void DownForce()
    {
        downForce = true;
        // rb.AddForce(Vector3.back * 0.5f);
    }

    public void LeftForce()
    {
        leftForce = true;
        // rb.AddForce(Vector3.left * 0.5f);
    }

    public void RightForce()
    {
        rightForce = true;
        // rb.AddForce(Vector3.right * 0.5f);
    }

    public void OnPointerDown(PointerEventData eventData){
        buttonPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData){
        buttonPressed = false;
        upForce = false;
        downForce = false;
        leftForce = false;
        rightForce = false;
    }
}
