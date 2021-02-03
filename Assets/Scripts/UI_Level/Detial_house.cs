using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detial_house : MonoBehaviour
{
    public GameObject Level_Building , Level_2 , Level_3;
    //public bool OnDetail = true;
    public StructureManager structureManager;
    public Button DeleteButton;
    public Button Uplevel_2;
    public Button Uplevel_3;
   
    public Vector3Int position;
     Homestate homestate;
    public Text textLevel, textPeople, textElec,textFood,textWater,texthealth, textFanciness, textsecurity, ironneeded;
    public Text[] woodneeded;
    public Item wood ,iron;

    

    // Start is called before the first frame update
    void Start()
    {
        //add money
        GameApplicationManager.Instance.addmoney(100);
        StorageSystem.instance.Reduce(wood, 1); 
        //add people
       // GameApplicationManager.Instance.addPeople(10);

        homestate = GetComponent<Homestate>();
       Button btn = DeleteButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Uplevel_2.onClick.AddListener(UpgradeLevel_2);
        Uplevel_3.onClick.AddListener(UpgradeLevel_3);

        textFood.text = "Foods : " + homestate.rice + "/5";
        texthealth.text = "Heath : " + homestate.PercentHealth + "%";
        textElec.text = "Electric : " + homestate.electricpower + "/5";
        textWater.text = "Water : " + homestate.Hydroenergy + "/5";
        textPeople.text = "People : " + homestate.people;
      
       




    }
    //Destory
    public void InitialPrefab(StructureManager structureManager, Vector3Int position)
    {
        this.structureManager = structureManager;
        this.position = position;
       
    }


    public void UpgradeLevel_2()
    {
        //Level 2
        if (wood.count >= 1 && homestate.level == 1)
        {
            homestate.level = 2;
            StorageSystem.instance.Reduce(wood, 1);
            Level_2.SetActive(false);
            Level_3.SetActive(true);
            Debug.Log("Upgrade!!! to Lv.2");
            ironneeded.text = " " + iron.count + "/1";
           
            woodneeded[1].text = " " + wood.count + "/1";
            textFood.text = "Foods : " + homestate.rice + "/15";
            texthealth.text = "Heath : " + homestate.PercentHealth + " %";
            textElec.text = "Electric : " + homestate.electricpower + "/7";
            textWater.text = "Water : " + homestate.Hydroenergy + "/7";
            textPeople.text = "People : 15" ;

            GameApplicationManager.Instance.addPeople(5);
            GameApplicationManager.Instance.addmoney(350);



        }
        else
        {
            Debug.Log("Can't Upgrade");
        }
    }

    public void UpgradeLevel_3()
    {
        //Level 3
        if (wood.count >= 1 && iron.count >= 1 && homestate.level == 2)
        {
            homestate.level = 3;
            StorageSystem.instance.Reduce(wood, 1);
            StorageSystem.instance.Reduce(iron, 1);
            Level_3.SetActive(false);

            Debug.Log("Upgrade!!! to Lv.3");

            textFood.text = "Foods : " + homestate.rice + "/20";
            texthealth.text = "Heath : " + homestate.PercentHealth + " %";
            textElec.text = "Electric : " + homestate.electricpower + "/10";
            textWater.text = "Water : " + homestate.Hydroenergy + "/10";
            textPeople.text = "People : 20";

            textLevel.text = "House Lv. Max";
            GameApplicationManager.Instance.addPeople(5);
            GameApplicationManager.Instance.addmoney(500);
        }
        else
        {
            Debug.Log("Can't Upgrade");
        }
    }



        public void TaskOnClick()
    {
        if (this.structureManager)
        {
            this.structureManager.RemoveStructure(gameObject, position);
        }
        GameApplicationManager.Instance.reducemoney(100);
        
      

    }
   

    // Update is called once per frame
    void Update()
    {

        woodneeded[0].text = " " + wood.count + "/1";
        textLevel.text = "House Lv. " + homestate.level;
        textsecurity.text = "Security : " + homestate.PercentSafty + "%";
        textFanciness.text = "Fanciness : " + homestate.fanciness + "%";


        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                   
                   
                    Level_Building.SetActive(true);

                }
               

            }

        }
    }

           
        
}


