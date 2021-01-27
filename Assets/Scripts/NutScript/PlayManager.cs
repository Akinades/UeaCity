using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public GameObject UIfactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {

                    if (hit.collider.gameObject.name == "Bank")
                    {
                        UIfactory.SetActive(true);
                    }
                }
            }
        }
    }
}
