using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class FillcolorGame : MonoBehaviour
{
    public MouseClickPaper mouseClickPaper;
    public static FillcolorGame instanceFCG;
    #region �ܼ� 
    //��l���C��(���s)
    public Button RedcolorPen;
    public Button BluecolorPen;
    public Button BlackcolorPen;
    //���\�}�����L
    public bool openredpen = false;
    public bool openbluepen = false;
    public bool openblackpen = false;
    //�T��
    public GameObject Themessage;
    //�T���C�⥬�L
    public bool messageblack = false;
    public bool messagered = false;
    public bool messageblue = false;
    //���}���O
    public GameObject ColoerGameMenu;
    
    #endregion

    //�Ϥ��}�C
    public Sprite[] PenColor;
    public Sprite[] Message;
    public Flowchart flowchart;
    public C1TimelineMgr c1TimelineMgr;
    

    void Start()
    {
        instanceFCG = this;
        RedcolorPen.onClick.AddListener(ClickRedPen);
        BluecolorPen.onClick.AddListener(ClickBluePen);
        BlackcolorPen.onClick.AddListener(ClickBlackPen);
        Themessage.GetComponent<Image>().sprite = Message[0];

        
    }
    void Update()
    {
        //�T�����ܧ�
        #region
        /*if (Themessage.GetComponent<Image>().sprite = Message[0])
        {
            messageblack = true;
        }*/
        if (MouseClickPaper.instanceMCP.blackfinish == true)
        {
            Themessage.GetComponent<Image>().sprite = Message[1];
            messagered = true;
        }
        if (MouseClickPaper.instanceMCP.redfinish == true)
        {
            Themessage.GetComponent<Image>().sprite = Message[2];
            messageblue = true;
        }
        #endregion
        if (Input.GetMouseButtonDown(0) & MouseClickPaper.instanceMCP.isopen==true)
        {
            ColoerGameMenu.SetActive(true);
            messageblack = true;
        }
        if(mouseClickPaper.blackfinish ==true && mouseClickPaper.bluefinish==true && mouseClickPaper.redfinish==true)
        {
          flowchart.SetBooleanVariable("填色遊戲成功",true);
          ColoerGameMenu.SetActive(false);
        }
        else
        {
         MouseClickPaper.instanceMCP.isopen=false;    
        }
        if(flowchart.GetBooleanVariable("填色遊戲")==true)
        {
         instanceFCG.GetComponent<FillcolorGame>().enabled=true;
        }
        
        if(flowchart.GetBooleanVariable("填色遊戲成功")==true)
        {
         mouseClickPaper.blackfinish=false;
         mouseClickPaper.bluefinish=false; 
         mouseClickPaper.redfinish=false;
        }
    }

    //my function
     
    #region ���\�}��
    void ClickRedPen()
    {
        openredpen = !openredpen;
        if (openredpen)
        {
            Debug.Log("�� �}");
            RedcolorPen.GetComponent<Image>().sprite = PenColor[1];
            BluecolorPen.GetComponent<Image>().sprite = PenColor[2];
            BlackcolorPen.GetComponent<Image>().sprite = PenColor[4];
            openbluepen = false;
            openblackpen = false;
        }
        else
        {
            Debug.Log("�� ��");
            RedcolorPen.GetComponent<Image>().sprite = PenColor[0];
        }
    }
    void ClickBluePen()
    {
        openbluepen = !openbluepen;
        if (openbluepen)
        {
            Debug.Log("�� �}");
            BluecolorPen.GetComponent<Image>().sprite = PenColor[3];
            BlackcolorPen.GetComponent<Image>().sprite = PenColor[4];
            RedcolorPen.GetComponent<Image>().sprite = PenColor[0];
            openredpen = false;
            openblackpen = false;
        }
        else
        {
            Debug.Log("�� ��");
            BluecolorPen.GetComponent<Image>().sprite = PenColor[2];
        }
    }
    void ClickBlackPen()
    {
        openblackpen = !openblackpen;
        if (openblackpen)
        {
            Debug.Log("�� �}");
            BlackcolorPen.GetComponent<Image>().sprite = PenColor[5];
            BluecolorPen.GetComponent<Image>().sprite = PenColor[2];
            RedcolorPen.GetComponent<Image>().sprite = PenColor[0];
            openbluepen = false;
            openredpen = false;

        }
        else
        {
            Debug.Log("�� ��");
            BlackcolorPen.GetComponent<Image>().sprite = PenColor[4];
        }
    }
    #endregion

    //���O
   

}