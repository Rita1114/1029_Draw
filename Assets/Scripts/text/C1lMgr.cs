using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using Fungus;


public class C1lMgr : MonoBehaviour
{
   public static string DebugSceneName;
    public static int startPointNumber;
    public GameObject playerObject;

    
    public Flowchart flowchart;

   
    // Start is called before the first frame update
    void Start()
    {
        playerObject =GameObject.Find("Player");
        if(!playerObject)
        {
            SceneManager.LoadScene("");
            DebugSceneName=SceneManager.GetActiveScene().name;
            
        }
        if(startPointNumber !=0)
        {
           GameObject a=GameObject.Find(startPointNumber.ToString()) as GameObject;
           if(a !=null)
           {
            playerObject.transform.position= a.transform.position;
           }
           startPointNumber=0;
        }
       

        
    }
     void Update()
    {
        
    }
}
