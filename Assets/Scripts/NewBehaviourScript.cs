using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawnScript : MonoBehaviour
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
        if(timer >= 10)
        {
            GameObject gameObject = Instantiate(foodSpawn, foodLocal.position,Quaternion.identity);
            timer = 0;
        }
    }
}
