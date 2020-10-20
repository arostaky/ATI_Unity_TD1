using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

public float vitesseDeplacement;
public float vitesseRotation;


    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKey(KeyCode.UpArrow)){

            transform.Translate(Vector3.forward*Time.deltaTime * vitesseDeplacement);
        }
        if(Input.GetKey(KeyCode.DownArrow)){

            transform.Translate(Vector3.back*Time.deltaTime * vitesseDeplacement);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.up*Time.deltaTime * vitesseRotation);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.down*Time.deltaTime * vitesseRotation);
        }
        
    }
}
