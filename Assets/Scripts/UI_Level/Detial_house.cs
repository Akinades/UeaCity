using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detial_house : MonoBehaviour
{
    public GameObject[] Level_Building;
    public float holdDownStartime;
    public bool OnDetail = true;
    public StructureManager structureManager;
    public Button DeleteButton;
    public Vector3Int position;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = DeleteButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    //Destory
    public void InitialPrefab(StructureManager structureManager, Vector3Int position)
    {
        this.structureManager = structureManager;
        this.position = position;
    }

    public void TaskOnClick()
    {
        if (this.structureManager)
        {
            this.structureManager.RemoveStructure(gameObject, position);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            holdDownStartime += Time.deltaTime;

            if (holdDownStartime <0.5)
            {
                OnDetail = false;
            }

        }
        else
        {
            holdDownStartime = 0;
            OnDetail = true;
        }
        
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == this.gameObject)
            {
                if (OnDetail == false)
                {

                   


                }
                

            }

        }
            
    }

           
        
}


