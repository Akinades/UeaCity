using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingObject : MonoBehaviour
{
    public GameObject ThisColudUI;
     public float holdDownStartime = 0; 
    void Start()
    {
holdDownStartime=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                holdDownStartime+= Time.deltaTime;    
            }
        }
        if (holdDownStartime > 5)
        {
            holdDownStartime = 0;
            ThisColudUI.SetActive(true);
        }

    }
        
    }

