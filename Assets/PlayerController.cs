using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private int speed = 10;
    private int numAcorns = 0;

    // Use this for initialization
    void Start() {
        Debug.Log("NUTTTTS BOIIII");
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Rigidbody rb = GetComponent<Rigidbody>();
    //     Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

    //     rb.transform.position += Movement * speed * Time.deltaTime;


    //     Physics.gravity = new Vector3(0f, -100f, 0f);
    // }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "Acorn") addAcorns(1);        
    }

    private void addAcorns(int num){
        numAcorns += num;
    }

    public int getNumAcorns(){
        return numAcorns;
    }

}