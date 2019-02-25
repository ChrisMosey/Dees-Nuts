using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonController : MonoBehaviour {

    public enum Season { WINTER, SPRING, SUMMER, FALL };

    private Season currentSeason = Season.SUMMER;

    public  GameObject[] winterObjects;
    public  GameObject[] summerObjects;
    public  GameObject[] springObjects;
    public  GameObject[] fallObjects;

    private void getGameObjects(){
        winterObjects = GameObject.FindGameObjectsWithTag("WINTER");
        summerObjects = GameObject.FindGameObjectsWithTag("SUMMER");
        springObjects = GameObject.FindGameObjectsWithTag("SPRING");
        fallObjects = GameObject.FindGameObjectsWithTag("FALL");
    }

    void Start() {
        getGameObjects();
        setSeason("SUMMER");
    }

    public void setSeason(string season){

        foreach (GameObject go in winterObjects) { 
            go.active = false;
        }
        foreach (GameObject go in summerObjects) { 
            go.active = false;
        }
        foreach (GameObject go in springObjects) { 
            go.active = false;
        }
        foreach (GameObject go in fallObjects) { 
            go.active = false;
        }
    

        Debug.Log("Season: "+season);

        // Change Season
        switch (season){
            case "WINTER":
                currentSeason = Season.WINTER; 
                foreach (GameObject go in winterObjects) {
                    go.active = true;
                }
                break;
            case "FALL":
                currentSeason = Season.FALL; 
                foreach (GameObject go in fallObjects) {
                    go.active = true;
                }
                break;
            case "SPRING":
                currentSeason = Season.SPRING; 
                foreach (GameObject go in springObjects) {
                    go.active = true;
                }
                break;
            default:
                currentSeason = Season.SUMMER; 
                foreach (GameObject go in summerObjects) {
                    go.active = true;
                }
                break;
      }
    }

    public Season getSeason(){
        return currentSeason;
    }

    public bool isWinter(){
        return getSeason() == Season.WINTER ? true : false;
    }

    public bool isSpring(){
        return getSeason() == Season.SPRING ? true : false;
    }

    public bool isSummer(){
        return getSeason() == Season.SUMMER ? true : false;
    }

    public bool isFall(){
        return getSeason() == Season.FALL ? true : false;
    }


}