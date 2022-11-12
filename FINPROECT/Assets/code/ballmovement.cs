using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{

    public Rigidbody ball_rigidbody;
    public int move_speed;
    public float horizontal;
    public float vertical;

    public float jumpPower = 200f;
    public Rigidbody rb;
    public bool isgrounded;

    void OnCollisionEnter ()
    {
        isgrounded = true;
      
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame  
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");

        var direction_and_speed = new Vector3(horizontal,0,vertical) * move_speed;
        ball_rigidbody.AddForce(direction_and_speed);
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            isgrounded = false;
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(isgrounded == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
    }
}
    