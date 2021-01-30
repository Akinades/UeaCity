using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElericFactorystate : MonoBehaviour
{
    public int electricpowerMax=50;
    public int electricpowerWant;
    public Homestate homestate;
    // Start is called before the first frame update
    void Start()
    {
        electricpowerWant=5;
    }

    // Update is called once per frame
    void Update()
    {
      // homestate.SetPercentRice(electricpowerWant); 
      // electricpowerMax-=electricpowerWant;
    }
     

    }
    
    // public void GetRiceWant(Homestate homestate,int Want){
    // this.homestate=homestate;
    // electricpowerWant=Want;
    // }