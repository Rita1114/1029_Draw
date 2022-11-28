using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Fungus;

public class C2TimelineMgr : MonoBehaviour
{

    public PlayableDirector AnimationController;
    public TimelineAsset[] timelines;
    public string[] timelinename;
    public Flowchart flowchart;
    private float duration=5;
    public GameObject player;
    
    

    public enum Status{AnimOn,AnimOff};
    public Status status;

    // Start is called before the first frame update
    public void Start()
    {
      
        for(int i=0; i<timelines.Length; i++)
      {
        if(flowchart.GetBooleanVariable(timelinename[i]))
        {
            
            AnimationController.Play(timelines[i]);
            flowchart.SetBooleanVariable(timelinename[i],false);
            
        }
      }
    } 
    // Update is called once per frame

    
     void Update()
    {
     
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
      
      if(flowchart.GetBooleanVariable("")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[2]);
           }
          }
           
          if(flowchart.GetBooleanVariable("")==true)
          {
           player.GetComponent<playerCtr1>().enabled=false;
          }
          else
          {
            player.GetComponent<playerCtr1>().enabled=true;
          }
          if(flowchart.GetBooleanVariable("")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[3]);
           }
          }

          
         
     
    }

   
}
