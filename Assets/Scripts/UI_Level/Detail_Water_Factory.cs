using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Detail_Water_Factory : MonoBehaviour
{
    public GameObject Level_Building;
    public StructureManager structureManager;
    public Vector3Int position;
    WaterFactorystate waterFactorystate;
    public Button DeleteButton;
    public Text textWaterDemand, textWaterCapacity; 
    // Start is called before the first frame update
    void Start()
    {
        GameApplicationManager.Instance.reducemoney(5000);
        waterFactorystate = GetComponent<WaterFactorystate>();
        Button btn = DeleteButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        textWaterDemand.text = "Hydropower demand : " + GameApplicationManager.Instance.SumHydroenergy;
        textWaterCapacity.text = "Hydropower Capacity : " + GameApplicationManager.Instance.HaveHydroenergy;

        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {

                    Level_Building.SetActive(true);

                }

            }

        }
    }
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
            GameApplicationManager.Instance.HaveHydroenergy -= waterFactorystate.HydroenergyMax;
            Debug.Log("Booomb"); 
        }
       



    }
}
