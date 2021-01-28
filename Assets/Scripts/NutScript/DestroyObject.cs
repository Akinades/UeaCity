using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    public StructureManager structureManager;
    public Vector3Int position;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick); 
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


}
