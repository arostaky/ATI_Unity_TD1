using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solei : MonoBehaviour{
    public float vitesseTournerAutour;
    public Transform centre;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(centre.position, Vector3.up, vitesseTournerAutour * Time.deltaTime);
    }
}
