using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;


public class Book : MonoBehaviour
{

    public Flowchart flowchart;
    public GameObject player;
    public GameObject book;
    public S3 s3;
    // Start is called before the first frame update
    void Start()
    {
         if(flowchart.GetBooleanVariable("拿到本子")==false)
          {
           book.SetActive(false);
          }
          
         
    }

    // Update is called once per frame
    void Update()
    {
        if(s3.GetComponent<S3>().Workbook==true)
        {
        // player.GetComponent<MouseMove>().enabled=false;
        }
        if(flowchart.GetBooleanVariable("拿到本子")==true)
          {
           book.SetActive(true);
          }
        return;
    }
}
