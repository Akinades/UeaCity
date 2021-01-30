using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homestate : MonoBehaviour
{
    [Header("Percent")]
    public int PercentRice;
    public int PercentElectricpower;
    public int PercentHydroenergy; 
    public int PercentSafty;
    public int PercentHealth;

    //public int Maxnumber;

   
    public int fanciness;
   // private bool check;
  [Header("Now")]
     public int rice;
     public int electricpower;

     [Header("Max")]
     public int electricpowerMax=5;
      public int people = 10;
    void Start()
    {
      
    }

    void Update()
    {
       PercentRice=(rice*100)/people;
       PercentElectricpower= (electricpower*100)/electricpowerMax;

      fanciness= (PercentRice+PercentElectricpower+PercentHydroenergy+PercentSafty+PercentHealth)/5;// fanciness= Currency/500 *100 
     Debug.Log(GameApplicationManager.Instance.SumFanciness);
     //if(check){

     }
    }

    //   public void SetPercentRice(int Importelectricpower){
    //      electricpower+=Importelectricpower;
    //   }

