using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mouse : MonoBehaviour
{

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode =CursorMode.Auto;
    //private Vector2 hotSpot =Vector2.zero;

    public GameObject icon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnPointEnter(PointerEventData eventData) //滑鼠移入
    //{
    //  Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    //}
    //private void OnPointOver(PointerEventData eventData) //滑鼠懸停每湞呼叫
    //{
    //  Cursor.SetCursor(null, hotSpot, cursorMode);
    //}
    void OnMouseEnter()
    {
       //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
       icon.SetActive(true);

    }
    
    
    void OnMouseExit()
    {
        //Cursor.SetCursor(null, hotSpot, cursorMode);
        icon.SetActive(false);
    }

}
