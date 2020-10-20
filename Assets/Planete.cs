using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planete : MonoBehaviour{
    public float vitesseRotation;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * vitesseRotation);
    }
}
