using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{   
    public int countItem;

    public Text countText;

    public Image icon;

    Item item;

    public void AddItem (Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        countItem = item.count;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }

    void Update()
    {   
        countItem = item.count;
        countText.text = countItem.ToString();
    }
    
}
