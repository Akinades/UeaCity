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
    private void Start()
    {
        uiController.OnRoadPlacement += RoadPlacementHandler;
        uiController.OnHousePlacement += HousePlacementHandler;
        uiController.OnGradenPlacement += GradenPlacementHandler;
        uiController.OnFactoryPlacement += FactoryPlacementHandler;
        uiController.OnServicePlacement += ServicePlacementHandler;
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
        inputManager.OnMouseClick += structureManager.placeGraden;

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

    private void Update()
    {
        cameraMovement.MoveCamera(new Vector3(inputManager.CameraMovementVector.x,0, inputManager.CameraMovementVector.y));
    }
}
