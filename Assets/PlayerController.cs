using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour 
{
public float speed;//the moving speed
//this hold the rigibody component of the object
private Rigidbody rb;
public float moveSpeed = 2f;
public Vector3 jump;
public float jumpForce = 2.8f; private bool isGrounded = false;

Vector3 movement;
// Use this for initialization
void Start () 
{
    //we get the Rigidbody component and put it in rb
    rb = GetComponent<Rigidbody>();
    jump = new Vector3(0.0f,2.0f , 2.0f);
}

//when trigger collision happens
void OnTriggerEnter(Collider other)
    {
        //if the other object entering our trigger zone
        //has a tag called "Pick Up"
        if (other.gameObject.CompareTag ("PickUp"))
            {
            //deactivat the other object
            other.gameObject.SetActive (false);
            }
    }

void OnCollisionEnter(Collision other)
{
    if (other.gameObject.tag == "ground")
    {
        isGrounded = true;
    } 
}

private void FixedUpdate()
    { 
        //get horizontal movement, left = -1, right = 1
        float moveHorizontal = Input.GetAxis ("Horizontal");
        //get horizontal movement, down = -1, up = 1
        //float moveVertical = Input.GetAxis ("Vertical");
        //create a Vector3 variable to store the X,Y,Z movement values
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 2.0f);
        //add the movement values to the rigidbody
        rb.AddForce (movement * speed);
    }

// Update is called once per frame
void Update () 
{
    if (isGrounded) 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false; 
        }
    }
}
}