using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject foodSpawn;
    public float timer;
    public Transform foodLocal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if(timer <= 60)
        {
            GameObject gameObject = Instantiate(foodSpawn, foodLocal.position,Quaternion.identity); 
        }
    }
}
