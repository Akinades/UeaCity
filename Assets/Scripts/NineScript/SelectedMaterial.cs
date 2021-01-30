using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedMaterial : MonoBehaviour
{

    public Button selected;

    public Image icon;

    public Item item;

   // public spawnitem ;

    private void Start()
    {

        selected = GetComponent<Button>();
        icon.sprite = item.icon;
        
    }

    public void CreateMaterial(Item newItem)
    {
        item = newItem;
        //spawnitem.instance.chooseItem(item);
    }
    
}
