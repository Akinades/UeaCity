using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Storage/Item")]
public class Item : ScriptableObject
{
    public string name = "New Item";
    public Sprite icon = null;
    public int count = 0;

    

    public GameObject Object;
    
    public void addItem(int add)
    {
        count += add;
    }

    public bool reduceItem(int reduce)
    {
        bool use;
        if(count > 0)
        {
            count -= reduce;
            use = true;

        }
        else
        {
            use = false;
        }

        return use;
    }

}
