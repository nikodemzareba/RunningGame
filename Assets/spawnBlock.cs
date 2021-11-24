using System.Collections;
using System.Collections.Generic; using UnityEngine;

public class spawnBlock : MonoBehaviour 
{

private GameObject Block;
private float offset = 10.0f;
private GameObject Collectible;

// Use this for initialization
void Start () 
{
    //find the block object
    Block = GameObject.Find("Block"); 
}

void OnTriggerEnter(Collider other)
{
    //add a new block relative to the z position of the current block
    Vector3 newPos = new Vector3(transform.position.x, transform.position.y, (float)(transform.position.z + offset));
    Instantiate(Block, newPos, transform.rotation); 
    //Instantiate(Collectible, newPos, transform.rotation);
}

}
