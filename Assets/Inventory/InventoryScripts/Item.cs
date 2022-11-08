using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/New Item")]
public class Item : ScriptableObject
{
    public string itemname;
    public Sprite itemimage;

    public bool equip;
}
