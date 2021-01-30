using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Detail_Electirc_Factory : MonoBehaviour
{
    public GameObject Level_Building;
    public StructureManager structureManager;
    public Vector3Int position;
    ElericFactorystate elericFactorystate;
    public Button DeleteButton;
    public Text textElectircDemand, textElcetricCapacity;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameApplicationManager.Instance.reducemoney(4000);
        elericFactorystate = GetComponent<ElericFactorystate>();
        Button btn = DeleteButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        textElectircDemand.text = "Elcectric demand : " + GameApplicationManager.Instance.SumElectricpower;
        textElcetricCapacity.text = "Electric Capacity : " + elericFactorystate.electricpowerMax;

        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject && gameManager.CheckBuilding == false)
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
            GameApplicationManager.Instance.HaveElectricpower -= elericFactorystate.electricpowerMax;
            Debug.Log("Booomb"); 
        }
       



    }
}
