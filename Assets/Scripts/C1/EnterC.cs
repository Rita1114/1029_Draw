using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterC : MonoBehaviour
{
    public Item Pen;
    public Item Book;
    public Item Coin;
    public Inventory MyBook;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.CompareTag("Player")
     &&other.GetType().ToString()=="UnityEngine.CapsuleCollider2D")
     {
        Debug.Log("in");
        SceneManager.LoadScene("C1-C");
      
            if (!MyBook.itemlist.Contains(Coin))
            {
                MyBook.itemlist.Add(Coin);
                InventoryMgr.RefreshItem();
            }
        GameMgr.IsFirstTimeLinePlayed = true;
        }
    }
}
