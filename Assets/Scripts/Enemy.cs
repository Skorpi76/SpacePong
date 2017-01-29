using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 7;
    Vector2 targetPos;
    GameObject ballObj;
    
    void Start()
    {
        // Создать ещё одну сцену, скопировать всё, удалить скрипты, и назначить новые, установить в меню новый второй 
       // мод игры плеер против плеера 

        ballObj = GameObject.FindGameObjectWithTag("Ball");
    }


    void Update()
    {
        targetPos = Vector2.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
        gameObject.transform.position = new Vector2(8, targetPos.y);
    }
}