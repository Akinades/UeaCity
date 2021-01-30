using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homestate : MonoBehaviour
{
    public int rice;
    public int electricpower;
    public int hydroenergy; 
    public int education;
    public int health;

    private int Maxnumber;

    public int people;
    public int fanciness;
    private bool check;

    void Start()
    {
      
    }

    void Update()
    {
      fanciness= (rice+electricpower+hydroenergy+education+health)/5;// fanciness= Currency/500 *100 
     //Debug.Log(GameApplicationManager.Instance.SumFanciness);
      
      if(check==false){
         GameApplicationManager.Instance.SumFanciness+=fanciness;
         check=true;
      }
     

      }
}
