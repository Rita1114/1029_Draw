using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Fungus;

public class C1TimelineMgr : MonoBehaviour
{

    public PlayableDirector AnimationController;
    public TimelineAsset[] timelines;
    public string[] timelinename;
    public Flowchart flowchart;
    private float duration=5;
    public  GameObject player;
    public GameObject drawgame,drawgameMgr;
    public static bool 拿到筆,拿到錢,填色遊戲成功;
    

    public MouseClickPaper mouseClickPaper;
    public C1TimelineMgr c1TimelineMgr;
    
    

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
           Debug.Log("123");
        }
        if(GameMgr.IsGetpan)
        {
          拿到筆=true;
        }

        if(flowchart.GetBooleanVariable("Aniplay"))
           {
             GetComponent<PlayableDirector>().enabled = false;
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

        }
        
      }
    } 
    // Update is called once per frame

    
     void Update()
    {
     
      switch(status)
        {
          case Status AnimOn:
          if(flowchart.GetBooleanVariable("canwalk")==false)
          {
           player.GetComponent<playerCtr1>().enabled=false;
          }
          else
          if(flowchart.GetBooleanVariable("canwalk")==true)
          {
           player.GetComponent<playerCtr1>().enabled=true;
           拿到錢=true;
          }
          break;
        }
         if(拿到筆==true)
        {
          flowchart.SetBooleanVariable("收集完",true);
        }
      
     
      
          if(flowchart.GetBooleanVariable("填色遊戲")==true&& 拿到筆==true)
          {
           player.GetComponent<playerCtr1>().enabled=false;
           mouseClickPaper.GetComponent<MouseClickPaper>().isopen=true;
           drawgame.SetActive(true);
           drawgameMgr.GetComponent<FillcolorGame>().enabled=true;
          }
         
          if(flowchart.GetBooleanVariable("爸出現1")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[2]);
            Debug.Log("有播");
           }
          }
          if(flowchart.GetBooleanVariable("動畫A23")==true)
          {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
              Debug.Log("有播");
              c1TimelineMgr.GetComponent<PlayableDirector>().enabled=true;
              AnimationController.Play(timelines[1]);
            }
          }
           if(flowchart.GetBooleanVariable("填色遊戲成功")==true)
          {
            DrawgameDone();
          }
          
          /*if(flowchart.GetBooleanVariable("")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[3]);
           }
          }*/
    }
    public void LittledrawAni1()
    {
      if(GameMgr.flowchart.GetBooleanVariable("動畫A23")==true)
          {
            AnimationController.Play(timelines[1]);
          }
    }
     
     public void DrawgameDone()
     {
       //player.GetComponent<MouseMove>().enabled=true;
            drawgame.SetActive(false);
            Debug.Log("填完");
            //flowchart.SendMessage("開頭30~31",完成填色);
            Fungus.Flowchart.BroadcastFungusMessage ("完成填色");
            GameMgr.drawgameDone=true;
     }

   /*public static void isdrawdone()
   {
      if(填色遊戲成功==true)
          {
            GameMgr.player.GetComponent<MouseMove>().enabled=true;
            GameMgr.drawgame.SetActive(false);
            GameMgr.flowchart.FindBlock("開頭30~31").enabled=true;
          }
   }*/
}
