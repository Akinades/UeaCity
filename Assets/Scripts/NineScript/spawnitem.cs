using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spawnitem : MonoBehaviour
{
    public Transform Materialparent;

    public Button selected;

    public Image icon;

    public Item item;

    public float time;

    SlotMaterial[] slots;

    void Start()
    {
        slots = Materialparent.GetComponentsInChildren<SlotMaterial>();

        selected = GetComponent<Button>();
        icon.sprite = item.icon;
    }

    void Update()
    {
        
    }

    public void chooseItem(Item item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].state == SlotMaterial.State.None)
            {
                slots[i].AddItem(item,time);
                break;
            }
        }
    }

}
