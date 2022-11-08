using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bookmark : MonoBehaviour
{
    public Button RedMarkbutton;
    public Button GreenMarkbutton;
    public Button BlueMarkbutton;
    public Button PurpleMarkbutton;

    public GameObject rightRedMark;
    public GameObject leftRedMark;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void ClickRedMark()
    {
        rightRedMark.SetActive(false);
        leftRedMark.SetActive(true);
    }

}
