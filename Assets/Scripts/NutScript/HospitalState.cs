using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalState : MonoBehaviour
{
    public int HealthMax=50;
   // public int electricpowerWant;
    //public Homestate homestate;
    // Start is called before the first frame update
    void Start()
    {
       // electricpowerWant=5;
     GameApplicationManager.Instance.HaveHealth+=HealthMax;
    }

    // Update is called once per frame
    void Update()
    {

    }
     

    }
    
 
