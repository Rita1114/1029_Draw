using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Fungus;
using UnityEngine.SceneManagement;

public class TimelineMgr : MonoBehaviour
{

    public PlayableDirector AnimationController;
    public TimelineAsset[] timelines;
    public string[] timelinename;
    public Flowchart flowchart;

    public GameObject sleep;
    private float duration=5;
    public GameObject player;
    public GameObject Bubble;
    
    public bool gamestart;

    public enum Status{AnimOn,AnimOff};
    public Status status;

    // Start is called before the first frame update
      public void Awake()
    {
        // load savefile
        if(GameMgr.IsFirstTimeLinePlayed)
        {
           flowchart.SetBooleanVariable("Aniplay",true);
           flowchart.SetBooleanVariable("canwalk",true);
        }
    }


    public void Start()
    {
      
        for(int i=0; i<timelines.Length; i++)
      {
        if(flowchart.GetBooleanVariable(timelinename[i]))
        {
            
            AnimationController.Play(timelines[i]);
            flowchart.SetBooleanVariable(timelinename[i],false);
            gamestart=true;
            
        }
      }
    } 
    // Update is called once per frame

    
     void Update()
    {
      if(Input.GetKeyDown(KeyCode.Mouse0))
      {
        sleep.SetActive(false);
        Invoke(nameof(look),duration);
      }
      switch(status)
        {
          case Status AnimOn:
          if(flowchart.GetBooleanVariable("start")==false)
          {
           player.GetComponent<playerCtr1>().enabled=false;
          }
          else
          if(flowchart.GetBooleanVariable("start")==true)
          {
           player.GetComponent<playerCtr1>().enabled=true;
          }
          break;
        }
      
      if(flowchart.GetBooleanVariable("卓盈走路")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[2]);
           }
          }
           
          if(flowchart.GetBooleanVariable("跟小女孩說話")==true)
          {
           player.GetComponent<playerCtr1>().enabled=false;
           Bubble.SetActive(false);
          }
          else
          {
            player.GetComponent<playerCtr1>().enabled=true;
          }
          if(flowchart.GetBooleanVariable("靠近洞")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[3]);
           }
          }
        if (flowchart.GetBooleanVariable("進第一章") == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("C1-L");
            }
        }




    }

    private void look()
    {
      if(flowchart.GetBooleanVariable("四處環視")==true)
      {
        AnimationController.Play(timelines[1]);
      }
        
        
    }
    
}
