using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanController : MonoBehaviour {

    public SeasonController seasonController;

    private Vector3 startingPos;

    void Start () {
        startingPos = this.transform.position;
    }

    private void Update(){        

        if(seasonController.isWinter()){
            this.transform.position = new Vector3(startingPos.x, startingPos.y, startingPos.z);
            // transform.Translate (Vector3.up * Input.GetAxis ("Vertical") * Speed * Time.deltaTime);
        }else{
            int amtToMelt = 50;
            this.transform.position = new Vector3(startingPos.x, startingPos.y - amtToMelt, startingPos.z);
        }

    }

}