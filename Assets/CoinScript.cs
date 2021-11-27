using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private GameObject playerP;
    public AudioClip collectSound;
    public GameHandler GH;
    // Start is called before the first frame update
    void Start()
    {
        playerP = GameObject.Find ("Player");
        GH = GameObject.Find("screen").GetComponent<GameHandler>();
    }

    void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Player") {
    AudioSource.PlayClipAtPoint(collectSound, transform.position);
    GH.coins++;
    Destroy(gameObject);//destory self
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
