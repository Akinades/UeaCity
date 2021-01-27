using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldUI : MonoBehaviour
{
    public Transform world;
    public RectTransform ui;
    public new Camera camera;

    void Start()
    {
        camera=Camera.main;
   
    }
    
    void Update()
    {
       //DebugLog("PP");
        ui.position = camera.WorldToScreenPoint(world.position);
    
    }
}
