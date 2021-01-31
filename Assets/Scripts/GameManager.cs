using SVS;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public CameraMovement cameraMovement;
    public RoadManager roadManager;
    public InputManager inputManager;

    public UIController uiController;
    public bool CheckBuilding = true; 
    public StructureManager structureManager;
    public ScrollandPinch scrollandPinch;
    public Text textDemand;
    public float holdDownStartime = 0; 
    private void Start()
    {
        uiController.OnRoadPlacement += RoadPlacementHandler;
        uiController.OnHousePlacement += HousePlacementHandler;
        uiController.OnGradenPlacement += FarmPlacementHandler;
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
        textDemand.text = " Park : 7500 $ ";
    }
    private void ServicePlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeService;
        textDemand.text = " Hospital : 7000 $ , Police office : 7500 $ ";
    }
    private void FactoryPlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeFactory;
        textDemand.text = " Power Station : 4000 $ , Waterwork : 5000 $ , Factory for free ";
    }
    private void FarmPlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeFarm;
        textDemand.text = " Farm : 1000 $  ";
    }

    private void HousePlacementHandler()
    {
        CheckBuilding = false;
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.placeHouse;
        textDemand.text = " House for free  ";
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
