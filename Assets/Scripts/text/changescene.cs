using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public int pointNumber;
    public string nextSceneName;

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
    public void Load(){
          SceneManager.LoadScene(nextSceneName);
          C1lMgr.startPointNumber= pointNumber;
    }

    public void Changescene()
    {
        SceneManager.LoadScene("text2");
        CheckInit.startPointNumber= pointNumber;
    } 
    public void EnterG()
    {
        SceneManager.LoadScene("C1-G");
        CheckInit.startPointNumber= pointNumber;
    } 
    public void EnterC()
    {
        SceneManager.LoadScene("C1-C");
        CheckInit.startPointNumber= pointNumber;
    } 
    public void EnterP()
    {
        SceneManager.LoadScene("C1-P");
        CheckInit.startPointNumber= pointNumber;
    } 
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.CompareTag("Player")
     &&other.GetType().ToString()=="UnityEngine.CapsuleCollider2D")
     {
        Load();
        GameMgr.IsFirstTimeLinePlayed = true;
     }
        
    }
   
}