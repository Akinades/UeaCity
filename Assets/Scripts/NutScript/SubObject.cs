using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider collider)
 {
   // Debug.Log("Hit");
     if (collider.gameObject.tag == "Building")
     {
         Debug.Log("Hit2");
         Destroy(this.gameObject);
     }
 }
}
