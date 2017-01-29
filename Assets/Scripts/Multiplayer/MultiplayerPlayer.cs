using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerPlayer : MonoBehaviour {

    public float speed;
     private Rigidbody2D rb;
    private bool isTrue = true;
    void Start () {
         rb = this.GetComponent<Rigidbody2D>();
      
     } 


    // Update is called once per frame
    void FixedUpdate () {
    
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(0f, 2f) * speed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(0f, -2f) * speed;
            }
            else
            {
                rb.velocity = new Vector2(0f, 0f);
            }
        
    }
}
