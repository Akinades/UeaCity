using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplicationManager : MonoBehaviour
{
 [Header("Currency")]
    public static int  Money = 10000;
    public int Banknote;
    public int Fanciness;// 10-500
    private int People;
[Header("Player status")]
    protected float Exp;
    public int Level;
[Header("Material")]    
    public Item Wood;
    public Item Steel;
    public Item Brick;
    public Item Rice;
    public Item Beef;
    public Item Plywood;
    public Item Hammer;
    public Item Book;
    public Item Pencil;
    public Item Ruler;
  
public int houseCount;
public int SumFanciness;
public int SumElectricpower;
public int HaveElectricpower;
    // Start is called before the first frame update
    void Start()
    {
        //Frist not 
     // Money=1000000;
     // Fanciness=10;
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
       // HomeStast.SetFanciness.(intfanciness );
       if(houseCount!=0){
Fanciness=SumFanciness/houseCount;
       }
      
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

    
    


}
