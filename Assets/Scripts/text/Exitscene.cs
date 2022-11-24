using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitscene : MonoBehaviour
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
    public void ExitG()
    {
        SceneManager.LoadScene("C1-L");
        CheckInit.startPointNumber= pointNumber;
        GameMgr.IsFirstTimeLinePlayed = true;
    } 
    public void ExitC()
    {
        SceneManager.LoadScene("C1-C");
        CheckInit.startPointNumber= pointNumber;
    } 
    public void ExitP()
    {
        SceneManager.LoadScene("C1-P");
        CheckInit.startPointNumber= pointNumber;
    } 
    
   
}
