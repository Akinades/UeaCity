using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homestate : MonoBehaviour
{
    public MiniEvent miniEvent;
    float timeRice;
    float timeHealth;
    private bool _LowRice;
    private bool _LowHealth;
    private bool _LowSecurity;
    [Header("Percent")]
    public int level;
    public int PercentRice;
    public int PercentElectricpower;
    public int PercentHydroenergy;
    public int PercentSafty;
    public int PercentHealth;
    public int PercentLoveHome;
     public Item riceCount; 
    //public int Maxnumber;


    public int fanciness;
    private bool check;
    [Header("Now")]
    public int rice;
    public int electricpower;
    public int Hydroenergy;
     public int Health;
     public int Security;

    [Header("Max")]
    public int electricpowerMax = 5;
    public int HydroenergypowerMax = 5;
    public int HealthMax=5;
    public int SecurityMax=5;
    public int people=10;
    void Start()
    {
        
        //add money
        GameApplicationManager.Instance.addmoney(100);
        GameApplicationManager.Instance.addPeople(10);
        GameApplicationManager.Instance.SumElectricpower += electricpowerMax;
        GameApplicationManager.Instance.SumHydroenergy += HydroenergypowerMax;
        GameApplicationManager.Instance.SumHealth+=HealthMax;
        GameApplicationManager.Instance.SumSecurity+=SecurityMax;
       // GameApplicationManager.Instance.houseCount++;//fortest
        PercentLoveHome=100;
    }

    void Update()
    {
       // Debug.Log(_LowRice);
        if (GameApplicationManager.Instance.HaveElectricpower > GameApplicationManager.Instance.SumElectricpower)
        {
            electricpower = electricpowerMax;
        }
        if(GameApplicationManager.Instance.HaveElectricpower < GameApplicationManager.Instance.SumElectricpower)
        {
            electricpower = GameApplicationManager.Instance.HaveElectricpower / GameApplicationManager.Instance.houseCount;
        }

        if (GameApplicationManager.Instance.HaveHydroenergy > GameApplicationManager.Instance.SumHydroenergy)
        {
            Hydroenergy = HydroenergypowerMax;
        }
        if (GameApplicationManager.Instance.HaveHydroenergy < GameApplicationManager.Instance.SumHydroenergy)
        {
            Hydroenergy = GameApplicationManager.Instance.HaveHydroenergy / GameApplicationManager.Instance.houseCount;
        }
        if (GameApplicationManager.Instance.HaveHealth > GameApplicationManager.Instance.SumHealth)
        {
            Health = HealthMax;
        }
        if (GameApplicationManager.Instance.HaveHealth < GameApplicationManager.Instance.SumHealth)
        {
            Health = GameApplicationManager.Instance.HaveHealth / GameApplicationManager.Instance.houseCount;
        }
         if (GameApplicationManager.Instance.HaveSecurity > GameApplicationManager.Instance.SumHealth)
        {
            Security = HealthMax;
        }
        if (GameApplicationManager.Instance.HaveSecurity < GameApplicationManager.Instance.SumSecurity)
        {
            Security = GameApplicationManager.Instance.HaveSecurity / GameApplicationManager.Instance.houseCount;
        }
        //Rice 
        rice = riceCount.count;
       timeRice+= Time.deltaTime;
     if(timeRice>300f){
         rice-=people;
         timeRice=0;
     }
       if( rice==0 )
       {
         _LowRice=true;
       
        }
        else{
         _LowRice=false;
        }
      miniEvent=GetComponent<MiniEvent>();
     miniEvent.LowRice(_LowRice);
     //Health
      if( Health<=2)
       {
         _LowHealth=true;
        }
        if( Health>2)
       {
         _LowHealth=false;
        }
      miniEvent.LowHealth(_LowHealth);
       //Security
        if( Security<=2)
       {
         _LowSecurity=true;
        }
        if( Security>2)
       {
         _LowSecurity=false;
        }
       miniEvent.LowSecurity(_LowSecurity);
//PercentLoveHome


        PercentRice = (rice * 100) / people;
        PercentElectricpower = (electricpower * 100) / electricpowerMax;
        PercentHydroenergy= (Hydroenergy * 100) / HydroenergypowerMax;
        PercentHealth=(Health*100)/HealthMax;
        PercentSafty=(Security*100)/SecurityMax;
        fanciness = (PercentRice + PercentElectricpower + PercentHydroenergy + PercentSafty + PercentHealth+PercentLoveHome) / 6;
        // fanciness= Currency/500 *100 
       //Debug.Log(GameApplicationManager.Instance.SumFanciness);

    }
    public void PercentLoveHomeDown(int Lovehome){
      PercentLoveHome-=Lovehome;
    }
}

//   public void SetPercentRice(int Importelectricpower){
//      electricpower+=Importelectricpower;
//   }

