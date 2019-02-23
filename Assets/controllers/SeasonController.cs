using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonController : MonoBehaviour {

    public enum Season { WINTER, SPRING, SUMMER, FALL };

    private Season currentSeason = Season.SUMMER;

    public void setSeason(string season){
        switch (season){
            case "WINTER":
                currentSeason = Season.WINTER; break;
            case "FALL":
                currentSeason = Season.FALL; break;
            case "SPRING":
                currentSeason = Season.SPRING; break;
            default:
                currentSeason = Season.SUMMER; break;
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