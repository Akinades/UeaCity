using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicestationState : MonoBehaviour
{
       public int SecurityMax=50;
   // public int electricpowerWant;
    //public Homestate homestate;
    // Start is called before the first frame update
    void Start()
    {
       // electricpowerWant=5;
     GameApplicationManager.Instance.HaveSecurity+=SecurityMax;
    }

    // Update is called once per frames
    void Update()
    {

    }
     

    }
    
