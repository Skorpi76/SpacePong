using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    /* private Rigidbody2D rb;
     void Start () {
         rb = this.GetComponent<Rigidbody2D>();
     }

     // Update is called once per frame
     void Update () {
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
     } */
    public float speed;
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0, moveVertical);
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }

   
}
