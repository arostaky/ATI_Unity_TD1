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
            acceleration = acceleration + (vitesseDeplacement * Time.deltaTime * accelerationSpeed);
            Debug.Log(acceleration);
            mouvement = Vector3.forward;
            //transform.Translate(Vector3.forward*Time.deltaTime  * acceleration);
            transform.Translate(mouvement*Time.deltaTime*acceleration);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            acceleration = acceleration + (vitesseDeplacement * Time.deltaTime * accelerationSpeed);
            Debug.Log(acceleration);
            mouvement = -1f * Vector3.forward;
            transform.Translate(mouvement*Time.deltaTime*acceleration);
            //transform.Translate(Vector3.back*Time.deltaTime * acceleration);
            // this works if you use negative numbers....
            //    if(acceleration < 0){
            //     acceleration = 0;
            // }
        }
        //Rotation:
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(Vector3.up*Time.deltaTime * vitesseRotation);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(Vector3.down*Time.deltaTime * vitesseRotation);
        }
    }
    void IncrementSpeed(float val){

    }
}
