using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageUI : MonoBehaviour
{
    public Transform itemsParent;

    StorageSystem storage;

    ItemSlot[] slots;

    void Start()
    {
        storage = StorageSystem.instance;
        storage.OnItemChanagedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<ItemSlot>();

        UpdateUI();
    }
    
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length;i++)
        {
            if( i < storage.items.Count)
            {
                slots[i].gameObject.SetActive(true);
                slots[i].AddItem(storage.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
                slots[i].gameObject.SetActive(false);
            }
        }
    }
}
