using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotMaterial : MonoBehaviour
{
    public enum State {None,Fill }
    public State state;
    public float timeSpawnItem;

    public Text text;

    public Image icon;
    public Image cancel;

    public Item item;

    public Detail_Factory Factory;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.None:
                cancel.gameObject.SetActive(false);
                text.text = "Empty";
                break;

            case State.Fill:
                if (timeSpawnItem > 0)
                {
                    timeSpawnItem -= Time.deltaTime;
                    cancel.gameObject.SetActive(true);
                    text.text = timeSpawnItem.ToString("0") + " sec";
                }
                else
                {
                    Factory.spawn(item);
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
        timeSpawnItem = 0;
        state = State.None;
    }
}
