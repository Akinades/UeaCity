using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CL : MonoBehaviour
{
    public Transform PlacementManager;
    public int num;
         Homestate[] homestate;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
         // homestate= FindGameObjectsWithTag("Home").GetComponents<Homestate>();
          GameObject[] reactors = GameObject.FindGameObjectsWithTag("Home");
      homestate = new Homestate[reactors.Length];
      for ( int i = 0; i < reactors.Length; ++i )
          homestate[i] = reactors[i].GetComponent<Homestate>();
         //  Debug.Log(homestate.Length);
//GameApplicationManager.Instance.SumFanciness=0;
               if(num>homestate.Length){
                     num=0;
                    GameApplicationManager.Instance.SumFanciness=0;
                      } 

 if(num<homestate.Length){  
for (int i = 0; i <homestate.Length;i++)
        { 
                 num++;
                GameApplicationManager.Instance.SumFanciness += homestate[i].fanciness;
                    Debug.Log(i);
                    Debug.Log( homestate[i].fanciness);
            }
             
                
        }

}
        
    
}
