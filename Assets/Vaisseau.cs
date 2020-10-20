using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaisseau : MonoBehaviour{
    public Transform planete1;
    public Transform planete2;
    public float distanceMin = 2f;
    // 
    private bool surPlanete1 = false;
    private bool surPlanete2 = false;
    //
    private float distance;
    public float vitesse;

    // Update is called once per frame
    void Update(){
        // there are many ways to do this, this is one of them, for sure this is not the best, but it works:

        // 1st measure the dist betw obj and planet-1:
        distance = Vector3.Distance( transform.position, planete1.position);
        // if we are not anywhere, we should move to a planet:
        if(surPlanete1 == false && surPlanete2 == false){
        transform.position = Vector3.MoveTowards(transform.position, planete1.position, Time.deltaTime * vitesse);
        transform.LookAt(planete1.position);
        }
        // then check if the ship is far or closer to the planet-1
        if (distance <= distanceMin){
            // if it is closer the boolean goes true:
            surPlanete1 = true;
            // we are not in planet2:
            surPlanete2 = false;
        }
        // if this surPlanete is true:
        if (surPlanete1 ==  true){
            // we move the ship to the next planet:
            transform.position = Vector3.MoveTowards(transform.position, planete2.position, Time.deltaTime * vitesse);
            transform.LookAt(planete2.position);
            // check distance again:
            distance = Vector3.Distance( transform.position, planete2.position);
            if(distance <= distanceMin){
                surPlanete2 = true;
                // we are not in planet-1:
                surPlanete1 = false;
            }
        }else{
            // we must reset distance again and make the ship go to the first planet
            distance = Vector3.Distance( transform.position, planete1.position);
            transform.position = Vector3.MoveTowards(transform.position, planete1.position, Time.deltaTime * vitesse);
            transform.LookAt(planete1.position);
        }
    }
}
