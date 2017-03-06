using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
  

    
     

    void FixedUpdate()
    {
       
 
      
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(0, moveVertical);
            GetComponent<Rigidbody2D>().velocity = movement * speed;
       
    }


}
