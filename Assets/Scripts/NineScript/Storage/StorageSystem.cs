﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageSystem : MonoBehaviour
{
    #region Sigleton

    public static StorageSystem instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanaged();
    public OnItemChanaged OnItemChanagedCallback;

    //public int space;

    public List<Item> items = new List<Item>();



    int privatecount;
    public int count;

    private void Update()
    {
        totalCount();
    }

    public void Add (Item item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if(item.name == items[i].name)
            {
                items[i].addItem(1);
                return;
            }
            /*if (item.name != items[i].name)
            {
                items.Add(item);
            }*/
        }

        if (OnItemChanagedCallback != null)
            OnItemChanagedCallback.Invoke();
    }

    public void Reduce(Item item ,int reduce)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (item.name == items[i].name)
            {
                items[i].reduceItem(reduce);
                break;
            }
            if (item.name != items[i].name)
            {
                items.Add(item);

            }
        }

        if (OnItemChanagedCallback != null)
            OnItemChanagedCallback.Invoke();
    }


    public void Clear(Item item)
    {
        items.Remove(item);

        if (OnItemChanagedCallback != null)
            OnItemChanagedCallback.Invoke();
    }

    public void totalCount()
    {
        privatecount = 0;
        for (int i = 0; i < items.Count; i++)
        {
            privatecount += items[i].count;
            
        }
        count = privatecount;
    }

    Item itemfind;

    public Item findItem(string name)
    {
        
        for (int i = 0; i < items.Count; i++)
        {
            if(items[i].name == name)
            {
                itemfind = items[i];
            }
            
            break;
        }

        return itemfind;
    }

}
