using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemMakeProblem : MonoBehaviour
{
     private float time = 0.0f;
 public float EverySecond = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          time += Time.deltaTime;
 
     if (time >= EverySecond) {
         time = 0.0f;
         GameApplicationManager.Instance.addmoney(10);
         GameApplicationManager.Instance.addExp(100);
         Debug.Log("Get Problem EverySecond ");
     }
    }
}
