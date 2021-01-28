using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Action OnRoadPlacement, OnHousePlacement, OnGradenPlacement,OnFactoryPlacement,OnServicePlacement,OnParkPlacement,OnNormal;
    public Button placeRoadButton, placeHouseButton, placeGradenButton,placeFactoryButton,placeServiceButton,placeParkButton,placeCancelButton;
    public Color outlineColor;
    public GameManager control; 
    List<Button> buttonList;
    
    private void Start()
    {
        buttonList = new List<Button> { placeHouseButton, placeRoadButton, placeGradenButton, placeFactoryButton,placeServiceButton, placeParkButton };
        
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
            
        });
        //สวัสดิ์การ
        placeServiceButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeServiceButton);
            OnServicePlacement?.Invoke();
           
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
