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

        slots = itemsParent.GetComponentsInChildren<ItemSlot>();
    }

    void CloseStorage()
    {
        this.gameObject.SetActive(false);
    }

    void OpenStorage()
    {
        this.gameObject.SetActive(true);
    }
}
