using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homestate : MonoBehaviour
{
    [Header("Percent")]
    public int level;
    public int PercentRice;
    public int PercentElectricpower;
    public int PercentHydroenergy;
    public int PercentSafty;
    public int PercentHealth;
    
    //public int Maxnumber;


    public int fanciness;
    private bool check;
    [Header("Now")]
    public int rice;
    public int electricpower;
    public int Hydroenergy;

    [Header("Max")]
    public int electricpowerMax = 5;
    public int HydroenergypowerMax = 10;
    public int people = 10;
    void Start()
    {
        //add money
        GameApplicationManager.Instance.addmoney(100);
        GameApplicationManager.Instance.SumElectricpower += electricpowerMax;
        GameApplicationManager.Instance.SumHydroenergy += HydroenergypowerMax;
       
    }

    void Update()
    {
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




        PercentRice = (rice * 100) / people;
        PercentElectricpower = (electricpower * 100) / electricpowerMax;
        PercentHydroenergy= (Hydroenergy * 100) / HydroenergypowerMax;
        fanciness = (PercentRice + PercentElectricpower + PercentHydroenergy + PercentSafty + PercentHealth) / 5;
        // fanciness= Currency/500 *100 
       //Debug.Log(GameApplicationManager.Instance.SumFanciness);

    }
}

//   public void SetPercentRice(int Importelectricpower){
//      electricpower+=Importelectricpower;
//   }

