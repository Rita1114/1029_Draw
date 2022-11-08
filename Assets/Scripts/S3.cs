using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S3 : MonoBehaviour
{
    public Slider BgmValue;//BGM�Ա�
    //
    public Button Workbookbutton;//�k�U�@�~��
    public GameObject Workbookhide;//�k�U�@�~��
    public GameObject Workbook;//���}���@�~��
    public Button Closebookbutton;

    public Button Notebutton;//�Ƨѿ����s
    public Button GameSettingbutton;//�C���]�m���s
    public Button BackMenu;//�^��D���
    public GameObject Notecontent;//�Ƨѿ����e
    public GameObject GameSeetingcontent;//�C���]�m���e
    public GameObject OldHouseThing;//�Ѯa�̪����e���~
    //Marks
    public Button RedMarkbutton;//�������
    public Button GreenMarkbutton;//��
    public Button BlueMarkbutton;//��
    public Button PurpleMarkbutton;//��

    public GameObject rightRedMark;//�S�������
    public GameObject leftsRedMark;//���������
    void Start()
    {
        
        Workbookbutton.onClick.AddListener(OpenWorkBook);
        Closebookbutton.onClick.AddListener(CloseWorkBook);
        Notebutton.onClick.AddListener(NoteContent); ;
        GameSettingbutton.onClick.AddListener(GameSettingContent);
        BackMenu.onClick.AddListener(ClickBackMenu);
        
        //Marks
        RedMarkbutton.onClick.AddListener(ClickRedMark);
    }

   
    void Update()
    {
        //BgmValue.value =S1.BGMSlider2.value;
    }
    #region �ڪ�function
    void OpenWorkBook()
    {
        SoundMgr.instance.PlayOpenBook();
        Workbook.SetActive(true);
        Workbookhide.SetActive(false);
        Notecontent.SetActive(true);
        GameSeetingcontent.SetActive(false);
        rightRedMark.SetActive(true);
        leftsRedMark.SetActive(false);
        OldHouseThing.SetActive(false);
    }
    void CloseWorkBook()
    {
        SoundMgr.instance.PlayClossBook();
        Workbook.SetActive(false);
        Workbookhide.SetActive(true);
    }
    void NoteContent()
    {
        SoundMgr.instance.PlayTurnPages();
        Notecontent.SetActive(true);
        GameSeetingcontent.SetActive(false);
        rightRedMark.SetActive(true);
        leftsRedMark.SetActive(false);
        OldHouseThing.SetActive(false);
    }
    void GameSettingContent()
    {
        SoundMgr.instance.PlayTurnPages();
        GameSeetingcontent.SetActive(true);
        Notecontent.SetActive(false);
        rightRedMark.SetActive(true);
        leftsRedMark.SetActive(false);
        OldHouseThing.SetActive(false);
    }
    void ClickBackMenu()
    {
        SoundMgr.instance.CirclesoundEffect();
        SceneManager.LoadScene("S1");
    }
    //Marks
    void ClickRedMark()
    {
        SoundMgr.instance.PlayTurnPages();
        rightRedMark.SetActive(false);
        leftsRedMark.SetActive(true);
        Notecontent.SetActive(false);
        GameSeetingcontent.SetActive(false);
        OldHouseThing.SetActive(true);
    }
    #endregion

    private void Awake()
    {
        if (GameMgr.IsBag)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);//���n�R��������
            GameMgr.IsBag = true;
        }

    }

}
