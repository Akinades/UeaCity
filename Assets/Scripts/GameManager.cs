using SVS;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CameraMovement cameraMovement;
    public RoadManager roadManager;
    public InputManager inputManager;

    public UIController uiController;
    public bool CheckBuilding = true; 
    public StructureManager structureManager;
    public ScrollandPinch scrollandPinch; 

    public float holdDownStartime = 0; 
    private void Start()
    {
        uiController.OnRoadPlacement += RoadPlacementHandler;
        uiController.OnHousePlacement += HousePlacementHandler;
        uiController.OnGradenPlacement += GradenPlacementHandler;
        uiController.OnFactoryPlacement += FactoryPlacementHandler;
        uiController.OnFactoryPlacement_2+= FactoryPlacementHandler;
        uiController.OnFactoryPlacement_3+= FactoryPlacementHandler;
        uiController.OnServicePlacement += ServicePlacementHandler;
        uiController.OnServicePlacement_2+= ServicePlacementHandler;
        uiController.OnParkPlacement += ParkPlacementHandler; 
        uiController.OnNormal += NormalHandler;
    }
    private void FixedUpdate()
    {
       if(Input.touchCount >=2 || CheckBuilding == true)
        {
            ClearInputActions();
            scrollandPinch.enabled = true;
        }else
        {
            scrollandPinch.enabled = false;
        }
       if(CheckBuilding == true)
        {
            scrollandPinch.enabled = true;
        }
    }
    private void ParkPlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placePark; 
    }
    private void ServicePlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeService;
    }
    private void FactoryPlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeFactory;
    }
    private void GradenPlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeFarm;

    }

    private void HousePlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeHouse;
    }

    private void RoadPlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();

        inputManager.OnMouseClick += roadManager.PlaceRoad;
        inputManager.OnMouseHold += roadManager.PlaceRoad;
        inputManager.OnMouseUp += roadManager.FinishPlacingRoad;
    }
    private void NormalHandler()
    {
        ClearInputActions();
    }
    private void ClearInputActions()
    {
        inputManager.OnMouseClick = null;
        inputManager.OnMouseHold = null;
        inputManager.OnMouseUp = null;
    }
   
     void Update()
    {
        cameraMovement.MoveCamera(new Vector3(inputManager.CameraMovementVector.x,0, inputManager.CameraMovementVector.y));
    }
 
}
