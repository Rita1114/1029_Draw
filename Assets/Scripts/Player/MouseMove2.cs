using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove2 : MonoBehaviour
{
public Vector3 targetPoint;
public float speed;
private Animator anim;
public bool HasMove;
int lastDirection;
public GameObject player;
public Vector2 _direction;
 private string[] idleDirections ={"idle-leftup","idle-leftdown","idle-rightdown","idle-rightup"};
 private string[] WalkDirections ={"walk-leftup","walk-leftdown","walk-rightdown","walk-rightup"};

void Awake()
{
        targetPoint = transform.position;
        anim =GetComponent<Animator>();
        float result1 =Vector2.SignedAngle(Vector2.up,Vector2.right);
}
void Update()
{
  string[] directionArray = null;
  
  transform.position =Vector3.MoveTowards(transform.position,targetPoint, speed*Time.deltaTime);
  //Debug.Log("動");
  // 轉換座標
  if(Input.GetMouseButtonDown(0))
  {
    targetPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    targetPoint.z =0;

    if(targetPoint.y != transform.position.y && targetPoint.x != transform.position.x)
    {
      Debug.Log("走");
      HasMove=true;
      directionArray=WalkDirections;
      
    }
    else 
    { 
      Debug.Log("not walk");
      anim.SetBool("can idle",true);
      directionArray =idleDirections;
      
      
    }
    anim.Play(directionArray[lastDirection]);
    
  }
  
}
/*public void SetDirection(Vector2 _direction)
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
    }*/

private int MoveDirction(Vector2 _direction)
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
        
  if(targetPoint.x>transform.position.x)
    {
     
    }
    else
    {
        
    }
    if(targetPoint.y>transform.position.y)
    {
        
    }
    return Mathf.FloorToInt(stepCount);
}
}
