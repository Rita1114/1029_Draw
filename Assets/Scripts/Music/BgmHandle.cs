using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmHandle : MonoBehaviour
{
    public GameObject Bgm01;
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        
    }
}
