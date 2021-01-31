using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemMakeProblem : MonoBehaviour
{
     private float time = 0.0f;
 public float EverySecond = 1200.0f;
 public GameObject UIBigEvent;
 public BigEvent bigevent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (time <= EverySecond) {
          time += Time.deltaTime;
         }
     if (time > EverySecond) {
         Debug.Log("Get Problem EverySecond ");
         UIBigEvent.SetActive(true);
     }
    }
}
