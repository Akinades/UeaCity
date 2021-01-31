using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniEvent : MonoBehaviour
{
    public Homestate homestate;
    public bool _LowRice;
    public bool _LowHealth;
    public bool _LowSecurity;
    [Header("Button")]
    public Button Food;
     public Button Health;
     public Button Security;
     [Header("GameObject")]
     public GameObject UIMiniEventFood;
     public GameObject UIMiniEventHealth;
      public GameObject UIMiniEventSecurity;
     public GameObject UIMainMiniEvent;
     public GameObject ButtonFood;
     public GameObject ButtonHealth;
     public GameObject ButtonSecurity;
      [Header("Timer")]
       public float timerFood;
      public float timerHealth;
      public float timerSecurity;
    // Start is called before the first frame update
    void Start()
    {
       
        Button btn = Food.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick); 
        Button btn2 = Health.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2); 
        Button btn3 = Security.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);
      
    }
     public void TaskOnClick(){
       UIMiniEventFood.SetActive(true);
    }
    public void TaskOnClick2(){
       UIMiniEventHealth.SetActive(true);

      }
      public void TaskOnClick3(){
      UIMiniEventSecurity.SetActive(true);
      }

    // Update is called once per frame
    void Update()
    {
       timerFood+=Time.deltaTime;
       timerHealth+=Time.deltaTime;
       timerSecurity+=Time.deltaTime;
       if(_LowRice==true||_LowHealth==true||_LowSecurity==true){
         UIMainMiniEvent.SetActive(true);
       }
       if(_LowRice==false&&_LowHealth==false&&_LowSecurity==false){
         UIMainMiniEvent.SetActive(false);
       }
        if(_LowRice==true){
          ButtonFood.SetActive(true);
          if(timerFood>60f){
             homestate=GetComponent<Homestate>();
             homestate.PercentLoveHomeDown(1);
             timerFood=0;
          }
        }
        if(_LowRice==false){
          ButtonFood.SetActive(false);
          timerFood=0;
        }
         if(_LowHealth==true){
          ButtonHealth.SetActive(true);
          if(timerHealth>60f){
             homestate=GetComponent<Homestate>();
             homestate.PercentLoveHomeDown(1);
             timerHealth=0;
          }
        }
        if(_LowHealth==false){
          ButtonHealth.SetActive(false);
          timerHealth=0;
        }
        if(_LowSecurity==true){
          ButtonSecurity.SetActive(true);
           if(timerSecurity>60f){
             homestate=GetComponent<Homestate>();
             homestate.PercentLoveHomeDown(1);
             timerSecurity=0;
          }
        }
        if(_LowSecurity==false){
          ButtonSecurity.SetActive(false);
          timerSecurity=0;
        }

    }

    public void LowRice(bool low){
      // Debug.Log(_LowRice+"    2");
      _LowRice= low  ;
      }
       public void LowHealth(bool low){
      _LowHealth=low ;
      }
      public void LowSecurity(bool low){
       _LowSecurity =low;
      }
}
