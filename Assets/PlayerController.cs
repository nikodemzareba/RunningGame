using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour {
public float speed;//the moving speed
//this hold the rigibody component of the object
private Rigidbody rb;
// Use this for initialization
void Start () {
//we get the Rigidbody component and put it in rb
rb = GetComponent<Rigidbody>();
}
private void FixedUpdate()
{ 
//get horizontal movement, left = -1, right = 1
float moveHorizontal = Input.GetAxis ("Horizontal");
//get horizontal movement, down = -1, up = 1
float moveVertical = Input.GetAxis ("Vertical");
//create a Vector3 variable to store the X,Y,Z movement values
Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//add the movement values to the rigidbody
rb.AddForce (movement * speed);

}
// Update is called once per frame
void Update () {
}
}