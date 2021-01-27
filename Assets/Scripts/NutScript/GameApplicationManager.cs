using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplicationManager : MonoBehaviour
{
 [Header("Currency")]
    public int Money;
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
    // Start is called before the first frame update
   void Start()
    {
        //Frist not 
      Money=1000000;
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
