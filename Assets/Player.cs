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
        // with up and down doesn't work:
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right*Time.deltaTime * vitesseRotation);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.left*Time.deltaTime * vitesseRotation);
        }
        
    }
}
