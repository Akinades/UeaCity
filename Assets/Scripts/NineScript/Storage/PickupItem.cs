using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public Item item;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {

                    Pickup();

                }

            }

        }
    }


    public void Pickup()
    {
        StorageSystem.instance.Add(item);
        Destroy(this.gameObject);

    }

    public void Use()
    {
        StorageSystem.instance.Reduce(item,1);
    }

}
