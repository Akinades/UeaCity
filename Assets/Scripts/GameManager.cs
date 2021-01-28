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

    public StructureManager structureManager;

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

    private void ParkPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placePark; 
    }
    private void ServicePlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeService;
    }
    private void FactoryPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeFactory;
    }
    private void GradenPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeGraden;

    }

    private void HousePlacementHandler()
    {
        
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeHouse;
       
    }

    private void RoadPlacementHandler()
    {
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
