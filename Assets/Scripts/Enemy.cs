using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 7;
    Vector2 targetPos;
    GameObject ballObj;
    // Use this for initialization
    void Start()
    {


        ballObj = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = Vector2.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
        gameObject.transform.position = new Vector2(8, targetPos.y);
    }
}