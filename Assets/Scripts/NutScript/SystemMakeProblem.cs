using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemMakeProblem : MonoBehaviour
{
     private float time = 0.0f;
 public float interpolationPeriod = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          time += Time.deltaTime;
 
     if (time >= interpolationPeriod) {
         time = 0.0f;
 
         Debug.Log("Get Problem every interpolationPeriod seconds");
     }
    }
}
