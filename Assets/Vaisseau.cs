using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaisseau : MonoBehaviour{
    public Transform planete1;
    public float vitesse;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, planete1.position, Time.deltaTime * vitesse);

    }
}
