using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

public float vitesseDeplacement;
public float vitesseRotation;
//Objectifs Bonus:
private float acceleration = 0;
public float accelerationSpeed;
private Vector3 mouvement = Vector3.zero;

    void Update(){

        if(acceleration>vitesseDeplacement){
            acceleration = vitesseDeplacement;
        }
        if(Input.GetKeyUp(KeyCode.UpArrow)){
            acceleration = 0;
        }
         if(Input.GetKeyUp(KeyCode.DownArrow)){
            acceleration = 0;
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            acceleration = acceleration + (vitesseDeplacement * Time.deltaTime);
            Debug.Log(acceleration);
            transform.Translate(Vector3.forward*Time.deltaTime  * acceleration);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            acceleration = acceleration + (vitesseDeplacement * Time.deltaTime);
            Debug.Log(acceleration);
            transform.Translate(Vector3.back*Time.deltaTime * acceleration);
            //    if(acceleration < 0){
            //     acceleration = 0;
            // }
        }
        // with up and down doesn't work the ship moves through the Y axe (can you explain this? did i mess with the camera?):
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right*Time.deltaTime * vitesseRotation);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.left*Time.deltaTime * vitesseRotation);
        }
    }
    void IncrementSpeed(float val){

    }
}
