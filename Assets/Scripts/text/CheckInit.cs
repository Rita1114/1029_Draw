using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckInit : MonoBehaviour
{
    public static string DebugSceneName;
    public static int startPointNumber;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        playerObject =GameObject.Find("player");
        if(!playerObject)
        {
            SceneManager.LoadScene("text2");
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
