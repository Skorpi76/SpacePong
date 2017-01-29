using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    /* private Rigidbody2D rb;
    private bool isTrue = true;
    void Start () {
         rb = this.GetComponent<Rigidbody2D>();
      
     } */

    
     

    void FixedUpdate()
    {
       
        // Если кто то нажал кнопку, мы меняем переменную и назначаем её на иф, и используем именно то что подходит под условие 
        // action = action ++ or action --, than if 0 than M, if 1 than AI 
        // Multiplayer 
      /*  if (Input.GetKey(KeyCode.M) && isTrue == true)
        {
            isTrue = false;
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
        else
        {  */
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(0, moveVertical);
            GetComponent<Rigidbody2D>().velocity = movement * speed;
       // }
    }


}
