using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MouseMove : MonoBehaviour
{

    public float speed = 5f;
    private Vector2 target;
    private Vector2 position;
    private Camera cam;

    Rigidbody2D Rb;
    Animator anim;

    public Flowchart flowchart;

    
    public TimelineMgr timelineMgr;
    public C1TimelineMgr c1TimelineMgr;

    public AudioMgr audioMgr;

    public Exitscene exitscene;
    
    

    int Hor =0;
    int Ver =0;
    
    int 右上=0;
    int 右下=0;
    int 左下=0;
    int 左上=0;

    private enum PlayerEnum{leftupIdle,leftdownIdle,rightupIdle,rightdownIdle,
    leftupWalk,leftdownWalk,rightupWalk,rightdownWalk}
    private PlayerEnum playerEnum;

    

    // Start is called before the first frame update
    void Start()
    {
      
     target = position;
     position.x = transform.position.x;
     position.y = transform.position.y;
     anim =GetComponent<Animator>();
     Rb = GetComponent<Rigidbody2D>();
     cam =Camera.main;
     
     
     
     
    }

    // Update is called once per frame
    void Update()
    {
      
     
     //float step =speed*Time.deltaTime;
     if(Input.GetKeyDown(KeyCode.Mouse0))
     {
      
      target.Set(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y)).x,Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y)).y);
      //audioMgr.WalkSourcePlay();
      
     }
     position.Set(transform.position.x,transform.position.y);

     if(Vector2.Distance(position,target) >=0.1f)
     {
        Rb.MovePosition(position+(target-position)*Time.deltaTime);
    
    
     }
    if(Vector2.Distance(position,target)>2f)
    {
     anim.SetBool("Walk",true);
    }
    else
    {
     anim.SetBool("Walk",false);
    }
     
     Debug.Log("速度"+Vector2.Distance(position,target));
     if(target.x-position.x >= 0)
     {
       Hor=0;

     }
     else
     {
       Hor=1;//左邊    
     }
     
     anim.SetInteger("Hor",Hor);
    
    if(target.y-position.y >= 0)
     {
       Ver=0;    
     }
     else
     {
       Ver=1;//下   
     }
     anim.SetInteger("Ver",Ver);
     
     

     /*if(target.y-position.y <= 0)
     {
       右下=2;
       anim.SetBool("右邊",true);
       anim.SetBool("上",false);
     }
     else
     {
       右下=3;//左下
       anim.SetBool("右邊",false);
       
     }
     anim.SetInteger("右下",右下);
    

     if(target.x-position.x <= 0)
     {
      右上=1;
      anim.SetBool("右邊",true);
      
      
     }
     else
     {
      右上=4;//左上
      anim.SetBool("右邊",false);
      //anim.SetBool("上",true);
      
     }
     anim.SetInteger("右上",右上);
     }*/
    
    
   
   /* public void OnGUI()
    {
        Event currentEvent =Event.current;
        Vector2 mousePos =new Vector2();
        Vector2 point = new Vector2();
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight-currentEvent.mousePosition.y;

        point =cam.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,0.0f));

        if(Input.GetMouseButtonDown(0))
        {
            target=point;
        }
    }*/
 }
  void OnTriggerEnter2D(Collider2D other)
    {
     /*if(other.gameObject.CompareTag("DoorG")
     &&other.GetType().ToString()=="UnityEngine.CapsuleCollider2D")
     {
     } */

    if(other.GetComponent<changescene>()!=null)
    {
      other.GetComponent<changescene>().Load();
    }
    }

}   


