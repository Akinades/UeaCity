using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    public StructureManager structureManager;
    public Vector3Int position;
    public Button DeleteButton;
    public Button MoveButton;
    public float holdDownStartime = 0; 
    public GameObject UIDelete;

public bool NotDown;
    //private Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = DeleteButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick); 
        Button btn2 = MoveButton.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2); 
       
    }

    public void InitialPrefab(StructureManager structureManager,Vector3Int position){
        this.structureManager = structureManager;
        this.position = position;
    }

   public void TaskOnClick(){
       if(this.structureManager){
           this.structureManager.RemoveStructure(gameObject,position);
       }
    }
    public void TaskOnClick2(){
 

      }

       void Update()
    {
        if (Input.GetMouseButtonDown(0)){
     if(NotDown=false)
      Debug.Log("Down");
        }
    if (Input.GetMouseButton(0))
                  {
                      holdDownStartime+= Time.deltaTime;
                      NotDown=true;
                  }
                  else {
                  holdDownStartime=0;    
                  }
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                   // Debug.Log("+");
                     if (holdDownStartime > 1.5f)
                     { 
                    UIDelete.SetActive(true);
                    
                     }
                }
                      
            }
    }

}
