using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public Item item;
    
    public void Pickup()
    {
        StorageSystem.instance.Add(item);
    }

    public void Use()
    {
        StorageSystem.instance.Reduce(item,1);
    }

}
