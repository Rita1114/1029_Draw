using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class playerCtr : MonoBehaviour
{

    public float Speed;
    public GameObject Bag;
    bool Isopen;

 
    private Transform Door;
    private bool isDoor;
    private Transform playertransform;
    private Rigidbody2D rb;
    private Vector3 moveDir;
    private float moveX,moveY;
    [SerializeField] private float moveSpeed =5;
    private CharacterController characterBase;
    
    public bool Getitem;
    public Animator anim;

    public Animator animwalk;
    int canWalk;

    // Start is called before the first frame update
    void Start()
    {
         anim = GetComponent<Animator>();
         canWalk=Animator.StringToHash("canwalk");
        
    }
    private void Awake()
    {
        characterBase=GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody2D>();
    } 

    // Update is called once per frame
    /*void Update()
    {
        OPBG();
        float moveX =0f;
        float moveY =0f;
        
        if (Input.GetKey(KeyCode.RightArrow)){
            moveX = +1f;}

            if(Input.GetKey(KeyCode.LeftArrow)){
            moveX =-1f;}

            if(Input.GetKey(KeyCode.UpArrow)){
            moveY = +1f;}
            
            if(Input.GetKey(KeyCode.DownArrow)){
            moveY =-1f;}

            moveDir = new Vector3(moveX,moveY).normalized;
            
            FindObjectsOfType<MoveAnimation>();
            


    }*/

    //private void OnTriggerEnter2D(Collider2D Coll)
    //{

    //    if(Input.GetKeyDown(KeyCode.G))
     //   { 
     //   if(Coll.gameObject.tag =="items")
      //  {
    //    Coll.gameObject.SetActive(false);
        ///Getitem =true;
      ///   Debug.Log("已獲得物品");
      //  }
       // else
       // {
       //      Debug.Log("未獲得物品");
      //  }
      //   }
     
        
    //}
        private void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal")*moveSpeed;
        moveY = Input.GetAxis("Vertical")*moveSpeed;

        

            rb.velocity =new Vector2(moveX,moveY);

            Vector2 direction =new Vector2(moveX,moveY);
            FindObjectOfType<MoveAnimation>().SetDirection(direction);
            Debug.Log("現在"+moveX+"速度");
            Debug.Log("現在"+moveY+"速度");
    }
    void OPBG()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Isopen = !Isopen;
            Bag.SetActive(Isopen);
        }
    }
      private  void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.name.ToLower().Contains("KEY"))//檢查名字
        {
            Destroy(other.gameObject);//刪除物件
        }
    }
    
   
public void function()
{
    if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime>1)
    Debug.Log("not play");
    else
    Debug.Log("play");
}
 
public void CanWalk()
    {
        animwalk.SetTrigger(canWalk);
    }

        
}

