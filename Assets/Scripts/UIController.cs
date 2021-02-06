using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Action OnRoadPlacement, OnHousePlacement, OnGradenPlacement, OnFactoryPlacement,OnFactoryPlacement_2,OnFactoryPlacement_3, OnServicePlacement,OnServicePlacement_2, OnParkPlacement,OnNormal;
    public Button placeRoadButton, placeHouseButton, placeGradenButton, placeFactoryButton,placeFactoryButton_2,placeFactoryButton_3,placeServiceButton,placeServiceButton_2, placeParkButton,placeCancelButton;
    public Color outlineColor;
    public GameManager control;
    public int OderFactory , OderService; 
    List<Button> buttonList;
    
    private void Start()
    {
        buttonList = new List<Button> { placeHouseButton, placeRoadButton, placeGradenButton, placeFactoryButton, placeFactoryButton_2, placeFactoryButton_3, placeServiceButton,placeServiceButton_2, placeParkButton , placeCancelButton };
        
        //ถนน
        placeRoadButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeRoadButton);
            OnRoadPlacement?.Invoke();
           


        });
        //บ้าน
        placeHouseButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHouseButton);
            OnHousePlacement?.Invoke();
            
        });

        //สวนผัก
        placeGradenButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeGradenButton);
            OnGradenPlacement?.Invoke();
           
        });
        //โรงงาน
        placeFactoryButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeFactoryButton);
            OnFactoryPlacement?.Invoke();
            OderFactory = 1;
        });
        placeFactoryButton_2.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeFactoryButton_2);
            OnFactoryPlacement_2?.Invoke();
            OderFactory = 2;
        });
        placeFactoryButton_3.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeFactoryButton_3);
            OnFactoryPlacement_3?.Invoke();
            OderFactory = 3; 
        });
        //สวัสดิ์การ
        placeServiceButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeServiceButton);
            OnServicePlacement?.Invoke();
            OderService = 1; 
        });
        placeServiceButton_2.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeServiceButton_2);
            OnServicePlacement_2?.Invoke();
            OderService = 2;
        });
        //สวนสาธารณะ
        placeParkButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeParkButton);
            OnParkPlacement?.Invoke();
            
        });
        //ยกเลิกสร้าง
        placeCancelButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            OnNormal?.Invoke();
           control.CheckBuilding = true; 


        });
    }

    private void ModifyOutline(Button button)
    {
        var outline = button.GetComponent<Outline>();
        outline.effectColor = outlineColor;
        outline.enabled = true;
    }
    private void ResetButtonColor()
    {
        foreach (Button button in buttonList)
        {
            button.GetComponent<Outline>().enabled = false;
        }
    }
}
