using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class changescene : MonoBehaviour
{
    public int pointNumber;
    public string nextSceneName;

    public static int startPointNumber;
    public static string abc;
    public PlayableDirector ChangeAni;
    public GameObject image;

    public static bool IsFirstTimeLinePlayed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.tag ="Portal";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
          SceneManager.LoadScene(nextSceneName);
          C1lMgr.startPointNumber= pointNumber;
          image.SetActive(true);
          ChangeAni.Play();
          

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
