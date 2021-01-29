﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detial_Park : MonoBehaviour
{
    public GameObject[] Level_Building;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    
                    if (GameApplicationManager.Instance.Park == 1)
                    {
                        Level_Building[0].SetActive(true);
                    }
                    if (GameApplicationManager.Instance.Park == 2)
                    {
                        Level_Building[1].SetActive(true);
                    }
                    if (GameApplicationManager.Instance.Park == 3)
                    {
                        Level_Building[2].SetActive(true);
                    }

                }
            }
        }
    }
}

