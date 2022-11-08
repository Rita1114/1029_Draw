using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickPaper : MonoBehaviour
{
    public FillcolorGame Fillcolor;
    public static MouseClickPaper instanceMCP;
    private Vector3 MousePosition;
    #region �ܼ�
    //
    public bool isopen = false;
    //�u���C��
    public GameObject BlackLine;
    public GameObject RedLine01;
    public GameObject RedLine02;
    public GameObject RedLine03;
    public GameObject BlueLine01;
    public GameObject BlueLine02;
    public GameObject BlueLine03;
    //�I���إ��L
    bool inblackcoll;
    bool inredcoll01;
    bool inredcoll02;
    bool inredcoll03;
    bool inbluecoll01;
    bool inbluecoll02;
    bool inbluecoll03;
    //�����W�����
    public bool blackfinish = false;
    public bool redfinish = false;
    public bool bluefinish = false;

    bool red01finish = false;
    bool red02finish = false;
    bool red03finish = false;

    bool blue01finish = false;
    bool blue02finish = false;
    bool blue03finish = false;
    #endregion
    void Start()
    {
        instanceMCP = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        //�I��W��
        #region
        if (Input.GetMouseButtonDown(0))
        {
            if (inblackcoll == true&FillcolorGame.instanceFCG.openblackpen==true&FillcolorGame.instanceFCG.messageblack==true)
            {
                BlackLine.SetActive(true);
                blackfinish = true;
            }
        }
        //��
        if (Input.GetMouseButtonDown(0))
        {
            if (inredcoll01 == true & FillcolorGame.instanceFCG.openredpen == true & FillcolorGame.instanceFCG.messagered==true)
            {
                RedLine01.SetActive(true);
                red01finish = true;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (inredcoll02 == true & FillcolorGame.instanceFCG.openredpen == true & FillcolorGame.instanceFCG.messagered == true)
            {
                RedLine02.SetActive(true);
                red02finish = true;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (inredcoll03 == true & FillcolorGame.instanceFCG.openredpen == true & FillcolorGame.instanceFCG.messagered == true)
            {
                RedLine03.SetActive(true);
                red03finish = true;
            }
        }
        //��
        if (Input.GetMouseButtonDown(0))
        {
            if (inbluecoll01 == true & FillcolorGame.instanceFCG.openbluepen == true & FillcolorGame.instanceFCG.messageblue == true)
            {
                BlueLine01.SetActive(true);
                blue01finish = true;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (inbluecoll02 == true & FillcolorGame.instanceFCG.openbluepen == true & FillcolorGame.instanceFCG.messageblue == true)
            {
                BlueLine02.SetActive(true);
                blue02finish = true;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (inbluecoll03 == true & FillcolorGame.instanceFCG.openbluepen == true & FillcolorGame.instanceFCG.messageblue == true)
            {
                BlueLine03.SetActive(true);
                blue03finish = true;
            }
        }
        #endregion
        //�����C�⧹������
        if (red01finish == true & red02finish == true & red03finish == true)
        {
            redfinish = true;
        }
        if (blue01finish == true & blue02finish == true & blue03finish == true)
        {
            bluefinish = true;
        }
    }

    #region �I��
    public void OnTriggerEnter2D(Collider2D other)
    {
        //��
        if (other.name.ToLower().Contains("blackcoll"))
        {
            //Debug.Log("BL");
            inblackcoll = true;
        }
        //��
        if (other.name.ToLower().Contains("redcoll01"))
        {
            inredcoll01 = true;
        }
        if (other.name.ToLower().Contains("redcoll02"))
        {
            inredcoll02 = true;
        }
        if (other.name.ToLower().Contains("redcoll03"))
        {
            inredcoll03 = true;
        }
        //��
        if (other.name.ToLower().Contains("bluecoll01"))
        {
            inbluecoll01 = true;
        }
        if (other.name.ToLower().Contains("bluecoll02"))
        {
            inbluecoll02 = true;
        }
        if (other.name.ToLower().Contains("bluecoll03"))
        {
            inbluecoll03 = true;
        }
        //��j��I��
        if (other.name.ToLower().Contains("holecheck"))
        {
            isopen = true;
        }
        
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        //��
        if (other.name.ToLower().Contains("blackcoll"))
        {
            //Debug.Log("NNN");
            inblackcoll = false;
        }
        //��
        if (other.name.ToLower().Contains("redcoll01"))
        {
            inredcoll01 = false;
        }
        if (other.name.ToLower().Contains("redcoll02"))
        {
            inredcoll02 = false;
        }
        if (other.name.ToLower().Contains("redcoll03"))
        {
            inredcoll03 = false;
        }
        //��
        if (other.name.ToLower().Contains("bluecoll01"))
        {
            inbluecoll01 = false;
        }
        if (other.name.ToLower().Contains("bluecoll02"))
        {
            inbluecoll02 = false;
        }
        if (other.name.ToLower().Contains("bluecoll03"))
        {
            inbluecoll03 = false;
        }

        //
        if (other.name.ToLower().Contains("hole"))
        {
            isopen = false;
        }
        
    }
    #endregion

    

}
