using SVS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StructureManager : MonoBehaviour
{   
    public StructurePrefabWeighted[] housesPrefabe, FarmPrefabe,ParkPrefabe,FactoryPrefabe,ServicePrfabe;
    public PlacementManager placementManager;
    public UIController uIController;
    public Text textRoad;
    public Item wood; 
    //private float[] houseWeights, gradenWeights, parkWeights,factoryWeights,serviceWeights;
    private void Start()
    {
        /*houseWeights = housesPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        gradenWeights = FarmPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        parkWeights = ParkPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        factoryWeights = FactoryPrefabe.Select(prefabStats => prefabStats.weight).ToArray();
        serviceWeights = ServicePrfabe.Select(prefabStats => prefabStats.weight).ToArray();*/
    }
  public void RemoveStructure(GameObject prefab,Vector3Int position)
    {
        placementManager.RemoveObjectOnTheMap(position, CellType.Empty);
        Destroy(prefab.transform.parent.gameObject);
 
    }
    public void placeService(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position) )
        {
           // int randomIndex = GetRandomWeightedIndex(serviceWeights);
            if(uIController.OderService == 1 && GameApplicationManager.Instance.Money > 7500)
            {
                GameApplicationManager.Instance.reducemoney(7500); 
                placementManager.PlaceObjectOnTheMap(position, ServicePrfabe[0].prefab, CellType.Structure);
              
            }
            if (uIController.OderService == 2 && GameApplicationManager.Instance.Money > 7000)
            {
                GameApplicationManager.Instance.reducemoney(7000);
                placementManager.PlaceObjectOnTheMap(position, ServicePrfabe[1].prefab, CellType.Structure);
               

            }
            AudioPlayer.instance.PlayPlacementSound();
        }
            
    }
    public void placeFactory(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position))
        {
            //int randomIndex = GetRandomWeightedIndex(factoryWeights);
            if (uIController.OderFactory == 1 && GameApplicationManager.Instance.Money > 4000 )
            {
                placementManager.PlaceObjectOnTheMap(position, FactoryPrefabe[0].prefab, CellType.Structure);
              
            }
            if (uIController.OderFactory == 2 && GameApplicationManager.Instance.Money > 5000)
            {
                placementManager.PlaceObjectOnTheMap(position, FactoryPrefabe[1].prefab, CellType.Structure);
              
            }
            if (uIController.OderFactory == 3 && GameApplicationManager.Instance.FactoryCount <3)
            {
                GameApplicationManager.Instance.addFactory(1); 
                placementManager.PlaceObjectOnTheMap(position, FactoryPrefabe[2].prefab, CellType.Structure);
                
            }
           
            AudioPlayer.instance.PlayPlacementSound();
        }
    }
    public void placeHouse(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position) && wood.count > 0)
        {
            //int randomIndex = GetRandomWeightedIndex(houseWeights);
             GameApplicationManager.Instance.houseCount++;
            Detial_house destroyObject = housesPrefabe[0].prefab.GetComponent<Detial_house>();
            destroyObject.InitialPrefab(this,position);

            placementManager.PlaceObjectOnTheMap(position, housesPrefabe[0].prefab, CellType.Structure);
            //add money
            GameApplicationManager.Instance.addmoney(100);
            //add people
            GameApplicationManager.Instance.addPeople(10);
          
            
            
            AudioPlayer.instance.PlayPlacementSound();
        }
    }

    public void placeFarm(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position)  && GameApplicationManager.Instance.FarmCount < 2 && GameApplicationManager.Instance.Money > 1000)
        {
            
                GameApplicationManager.Instance.addFarm(1);
            GameApplicationManager.Instance.reducemoney(1000);
                placementManager.PlaceObjectOnTheMap(position, FarmPrefabe[0].prefab, CellType.Structure);
            
            
            //int randomIndex = GetRandomWeightedIndex(gradenWeights);
          
          
            AudioPlayer.instance.PlayPlacementSound();
        }
    }
    public void placePark(Vector3Int position)
    {
        if (CheckPositionBeforePlacement(position) && GameApplicationManager.Instance.Money > 7500)
        {
            //int randomIndex = GetRandomWeightedIndex(parkWeights);
            GameApplicationManager.Instance.reducemoney(7500); 
            placementManager.PlaceObjectOnTheMap(position, ParkPrefabe[0].prefab, CellType.Structure);
         
            AudioPlayer.instance.PlayPlacementSound();
        }
    }
    


    private int GetRandomWeightedIndex(float[] weights)
    {
        float sum = 0f;
        for (int i = 0; i < weights.Length; i++)
        {
            sum += weights[i];
        }

        float randomValue = UnityEngine.Random.Range(0, sum);
        float tempSum = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            //0->weihg[0] weight[0]->weight[1]
            if(randomValue >= tempSum && randomValue < tempSum + weights[i])
            {
                return i;
            }
            tempSum += weights[i];
        }
        return 0;
    }

    private bool CheckPositionBeforePlacement(Vector3Int position)
    {
        if (placementManager.CheckIfPositionInBound(position) == false)
        {
            Debug.Log("This position is out of bounds");
            textRoad.text = "This position is out of bounds";
            return false;
        }
        if (placementManager.CheckIfPositionIsFree(position) == false)
        {
            Debug.Log("This position is not EMPTY");
            textRoad.text = "This position is not EMPTY";
            return false;
        }
        if(placementManager.GetNeighboursOfTypeFor(position,CellType.Road).Count <= 0)
        {
            Debug.Log("Must be placed near a road");
            textRoad.text = "Must be placed near a road";
            return false;
        }
        return true;
    }
}

[Serializable]
public struct StructurePrefabWeighted
{
    public GameObject prefab;
    [Range(0,1)]
    public float weight;
}
