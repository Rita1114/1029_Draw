﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation1 : MonoBehaviour
{

    private Animator anim;
    private string[] idleDirections ={"idle-leftup","idle-leftdown","idle-rightdown","idle-rightup"};
    private string[] WalkDirections ={"walk-leftup","walk-leftdown","walk-rightdown","walk-rightup"};

     int lastDirection;
    // Start is called before the first frame update
    private void Awake()
    {
        anim =GetComponent<Animator>();

        float result1 =Vector2.SignedAngle(Vector2.up,Vector2.right);
        Debug.Log("R1"+result1);
    }

    public void SetDirection(Vector2 _direction)
    {
       string[] directionArray = null;
       if(_direction.magnitude<0.01)
       {
           directionArray =idleDirections;
       }
       else
       {
           directionArray=WalkDirections;
           lastDirection =DirectionToIndex(_direction);
       }
       anim.Play(directionArray[lastDirection]);
    }

    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 noDir =_direction.normalized;
        float step =360/4;
        float offset =step/4 ;  

        float angle = Vector2.SignedAngle(Vector2.up,noDir);

        angle += offset;
        if (angle < 0)
        {
            angle += 360;
        }
        float stepCount =angle / step;
        return Mathf.FloorToInt(stepCount);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}