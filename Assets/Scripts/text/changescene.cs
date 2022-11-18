using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public int pointNumber;
    public static int startPointNumber;
    public static string abc;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.tag ="Portal";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Changescene()
    {
        SceneManager.LoadScene("text2");
        CheckInit.startPointNumber= pointNumber;
    } 
     void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.CompareTag("Player")
     &&other.GetType().ToString()=="UnityEngine.CapsuleCollider2D")
     {
        Changescene();
     }
        
    }     
   
}
