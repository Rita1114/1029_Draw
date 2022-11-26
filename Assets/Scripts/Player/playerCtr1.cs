using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;


public class playerCtr1 : MonoBehaviour
{
    public float Speed;
    public GameObject Bag;
    bool Isopen;


    private Transform Door;
    private bool isDoor;
    private Transform playertransform;
    private Rigidbody2D rb;
    private Vector3 moveDir;
    private float moveX, moveY,direction;
    [SerializeField] private float moveSpeed = 5;
    private CharacterController characterBase;

    public bool Getitem;
    public Animator anim;
    int canWalk;
    public Vector3 targetPoint;
    private Vector2 MousePositionLast;
    private Vector3 MouseWorldMoveDirection;

    public float h, v;


    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        characterBase = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody2D>();
        targetPoint = transform.position;
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
      
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, moveSpeed * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            targetPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPoint.z = 0;
        }

        rb.velocity = new Vector2(targetPoint.x, targetPoint.y);

        Vector2 direction = new Vector2(targetPoint.x, targetPoint.y);
        Vector2 Walkdirection = new Vector2(transform.position.x-targetPoint.x, transform.position.y-targetPoint.y).Abs();
        FindObjectOfType<MoveAnimation>().WalkDirection(Walkdirection);
        FindObjectOfType<MoveAnimation>().SetDirection(direction);
        
        
        
        
    }

    void Update()
    {
    }

    void OPBG()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Isopen = !Isopen;
            Bag.SetActive(Isopen);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.ToLower().Contains("KEY")) //檢查名字
        {
            Destroy(other.gameObject); //刪除物件
        }
    }


    public void function()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            Debug.Log("not play");
        else
            Debug.Log("play");
    }
}