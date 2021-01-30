using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElericFactorystate : MonoBehaviour
{
    public int electricpowerMax=50;
   // public int electricpowerWant;
    //public Homestate homestate;
    // Start is called before the first frame update
    void Start()
    {
       // electricpowerWant=5;
     GameApplicationManager.Instance.HaveElectricpower+=electricpowerMax;
        GameApplicationManager.Instance.reducemoney(6000);
    }

    // Update is called once per frame
    void Update()
    {

        

    }
     

    }
    
 