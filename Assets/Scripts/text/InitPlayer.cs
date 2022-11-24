using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitPlayer : MonoBehaviour
{
    public string startScene;
    // Start is called before the first frame update
    void Start()
    {
        if(C1lMgr.DebugSceneName=="")
        {
         SceneManager.LoadScene(startScene);
        }
        else
        {
         SceneManager.LoadScene(C1lMgr.DebugSceneName);
         C1lMgr.DebugSceneName="";
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
