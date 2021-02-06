using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building_UI : MonoBehaviour
{
    public Animator buildingUI;
    public GameObject buildObject; 
     bool buildON = false;
    public Button buildClick;
     int ClickCount = 0;
    // Start is called before the first frame update

    void Start()
    {

        Animator  buildingUI = GetComponent<Animator>();
        buildClick.onClick.AddListener(BuildingClick);

      


    }

    // Update is called once per frame
    void Update()
    {

        if(buildON == true && ClickCount == 1)
        {
            buildObject.SetActive(true);
            buildingUI.Play("Panel_UI");
        }else if ( ClickCount == 2 )
        {
            ClickCount = 0; 
            buildON = false;
            buildObject.SetActive(false); 



        }else
        {

        }
       
    }
    void BuildingClick()
    {
        buildON = true;
        ClickCount += 1;
        buildingUI.enabled = true;
    }


}
