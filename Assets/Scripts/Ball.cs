using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Rigidbody2D rb;
    bool isPlay;
    public float speed;
    public GameObject Player;
    public GameObject Enemy;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("PlayerPaddle");
        Enemy = GameObject.Find("EnemyPaddle");
	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKey(KeyCode.Q) && isPlay == false)
        {
            int directionX = Random.Range(-1, 2);
            int directionY = Random.Range(-1, 2);
            if (directionX == 0)
                directionX = 1;
            
            isPlay = true; 
            rb.velocity = new Vector2(2f * directionX, 2f * directionY) * speed;
        }

        if (this.transform.position.x >= 10f)
        {
            this.transform.position = new Vector2(0f, 0f);
            isPlay = false;
            rb.velocity = new Vector2(0f, 0f);
        }
        if (this.transform.position.x <= -10f)
        {
            this.transform.position = new Vector2(0f, 0f);
            isPlay = false;
            rb.velocity = new Vector2(0f, 0f);
        }
       // yield return new WaitForSeconds(2); this function will do next action after 2 second. 
    }
    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.name == "PlayerPaddle") 
        {
            if (Player.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(2f, 2f) * speed;
            }
            else if (Player.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(2f, -2f) * speed;
            }
            else
            {
                rb.velocity = new Vector2(2f , 0.5f) * speed;
            }



        }
        if(hit.gameObject.name == "EnemyPaddle")
        {
            if (Enemy.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-2f, 2f) * speed;
            }
            else if (Enemy.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-2f, -2f) * speed;
            }
            else
            {
                rb.velocity = new Vector2(-2f, 0.5f) * speed;
            }

        }
    }
}
