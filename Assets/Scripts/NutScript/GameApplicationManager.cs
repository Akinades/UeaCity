using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplicationManager : MonoBehaviour
{
 [Header("Currency")]
    public static int  Money = 10000;
    public int Banknote;
    private int Fanciness;// 10-500
    private int People;
[Header("Player status")]
    protected float Exp;
    public int Level;
[Header("Material")]    
    public int Wood;
    public int Steel;
    public int Brick;
    public int Rice;
    public int Beef;
    public int Plywood;
    public int Hammer;
    public int Book;
    public int Pencil;
    public int Ruler;
    [Header("Sturcture Level")]
    public int house = 1;
    public int Factory_1 =1;
    public int Factory_2 =1;
    public int Factory_3 =1 ;
    public int Park =1;
    public int Garden =1 ;
    public int Service_1 = 1;
    public int Service_2 =1 ;

    // Start is called before the first frame update
    void Start()
    {
        //Frist not 
     // Money=1000000;
      Fanciness=10;
      Level=1;
    }
    static public GameApplicationManager Instance

    {
        get
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = GameObject.FindObjectOfType<GameApplicationManager>();
                GameObject container = new GameObject("GameApplicationManager");
                _singletonInstance = container.AddComponent<GameApplicationManager>();
            }
            return _singletonInstance;
        }
    }


    static protected GameApplicationManager _singletonInstance = null;
      void Awake()
    {
        if (_singletonInstance == null)
        {
            _singletonInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _singletonInstance)
            {
                Destroy(this.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    // Variables 
    public void addmoney(int value) {
         Money+=value;
         Debug.Log("Now Money =" + Money);
}
public void reducemoney(int value) {
         Money-=value;
          Debug.Log("Now Money =" + Money);
}
  public void reduceBanknote(int value) {
         Banknote-=value;
}
public void addFanciness(int value) {
         Fanciness+=value;

}
public void reduceFanciness(int value) {
         Fanciness-=value;
}
public void addPeople(int value) {
         People+=value;
        Debug.Log("People : " + People);

}
public void reducePeople(int value) {
         People-=value;
}
public void addExp(float value) {
         Exp+=value;
          Debug.Log("Now Exp =" + Exp);
}
public void addLevel(int value) {
         Level+=value;
          Debug.Log("Now Level =" + Exp);
}

    // Structure Level 
    //House
    public void AddLevelHouse(int value)
    {
        house += value;
        Debug.Log("House LV. =" + house);
    }
    //Factory
    public void AddLevelFactory_1(int value)
    {
        Factory_1 += value;
        Debug.Log("Factory_1 Lv. =" + Factory_1);
    }
    public void AddLevelFactory_2(int value)
    {
        Factory_2 += value;
        Debug.Log("Factory_2 Lv. =" + Factory_2);
    }
    public void AddLevelFactory_3(int value)
    {
        Factory_3 += value;
        Debug.Log("Factory_3 Lv. =" + Factory_3);
    }
    //Garden
    public void AddLevelGarden(int value)
    {
        Garden += value;
        Debug.Log("Garden Lv. =" + Garden);
    }
    //Park
    public void AddLevelPark(int value)
    {
        Park += value;
        Debug.Log("Park Lv. =" + Park);
    }
    //Service
    public void AddLevelService_1(int value)
    {
        Service_1 += value;
        Debug.Log("Service_1 Lv. =" + Service_1);
    }
    public void AddLevelService_2(int value)
    {
        Service_2 += value;
        Debug.Log("Service_2" + Service_2);
    }
}
