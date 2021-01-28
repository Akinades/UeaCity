using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Action OnRoadPlacement, OnHousePlacement, OnGradenPlacement,OnFactoryPlacement,OnServicePlacement,OnParkPlacement,OnNormal;
    public Button placeRoadButton, placeHouseButton, placeGradenButton,placeFactoryButton,placeServiceButton,placParkButton,placeCancelButton;
    public GameObject plane;
    public Color outlineColor;
    List<Button> buttonList;
    
    private void Start()
    {
        buttonList = new List<Button> { placeHouseButton, placeRoadButton, placeGradenButton };
        
        //ถนน
        placeRoadButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeRoadButton);
            OnRoadPlacement?.Invoke();
            plane.GetComponent<ScrollandPinch>().enabled = false;


        });
        //บ้าน
        placeHouseButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHouseButton);
            OnHousePlacement?.Invoke();
            plane.GetComponent<ScrollandPinch>().enabled = false;
        });

        //สวนผัก
        placeGradenButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeGradenButton);
            OnGradenPlacement?.Invoke();
            plane.GetComponent<ScrollandPinch>().enabled = false;
        });

        //ยกเลิกสร้าง
           placeCancelButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
           OnNormal?.Invoke();
            plane.GetComponent<ScrollandPinch>().enabled = true;


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
