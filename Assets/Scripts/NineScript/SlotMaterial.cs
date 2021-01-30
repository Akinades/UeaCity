using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotMaterial : MonoBehaviour
{
    public enum State {None,Fill }
    public State state;
    public float timeSpawnItem;

    public Image icon;

    public Item item;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.None:
               
                break;

            case State.Fill:
                if (timeSpawnItem > 0)
                {
                    timeSpawnItem -= Time.deltaTime;
                }
                else
                {
                    ClearSlot();
                }
                
                break;
        }
    }

    public void AddItem(Item newItem,float time)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        timeSpawnItem = time;
        state = State.Fill;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        state = State.None;
    }
}
