using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        SoundMgr.instance.PlayPenCirclesoundEffect();
    }
}
