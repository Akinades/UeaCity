using System.Collections;
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

    public void Add (Item item)
    {   
        for(int i = 0; i < items.Count; i++)
        {
            if(item.name == items[i].name)
            {
                items[i].count++;
            }
            else if (item.name != items[i].name)
            {
                items.Add(item);
            }
        }
    }

    public void Clear(Item item)
    {
        items.Remove(item);
    }

}
