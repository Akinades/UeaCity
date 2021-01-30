using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusObject : MonoBehaviour
{
    public Button Resetcamera;
    public Transform cameraZoom, Oldcamera;
    public Vector3Int position;
   // public StructureManager structureManager;
    // Start is called before the first frame update
    void Start()
    {
        Resetcamera.onClick.AddListener(ResetCamera);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*public void InitialPrefab(StructureManager structureManager, Vector3Int position)
    {
        this.structureManager = structureManager;
        this.position = position;

    }*/
    public void ResetCamera()
    {
        Camera.main.transform.LookAt(this.gameObject.transform, position);
        Camera.main.transform.position = Oldcamera.position;
        Camera.main.transform.rotation = Oldcamera.rotation;

    }
}
