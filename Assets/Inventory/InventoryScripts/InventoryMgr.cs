using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryMgr : MonoBehaviour
{
    static InventoryMgr instanceIVTMGR;

    public Inventory Mybag;
    public GameObject panalGrid;
    public Slot slotprefab;

    void Awake()
    {
        if (instanceIVTMGR != null)
            Destroy(this);
        instanceIVTMGR = this;
    }
    private void OnEnable()
    {
        RefreshItem();
    }
    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(instanceIVTMGR.slotprefab, instanceIVTMGR.panalGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instanceIVTMGR.panalGrid.transform);
        newItem.slotItem = item;
        newItem.slotimage.sprite = item.itemimage;
    }

    public static void RefreshItem()
    {
        for(int i = 0; i < instanceIVTMGR.panalGrid.transform.childCount; i++)
        {
            if (instanceIVTMGR.panalGrid.transform.childCount == 0)
                break;
            Destroy(instanceIVTMGR.panalGrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < instanceIVTMGR.Mybag.itemlist.Count; i++)
        {
            CreateNewItem(instanceIVTMGR.Mybag.itemlist[i]);
        }
    }


}
