using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour{
    private Vector3 axe = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        axe.x = Random.Range(-90,90);
        axe.y = Random.Range(-90,90);
        axe.z = Random.Range(-90,90);
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Rotate(axe * Time.deltaTime);
    }
}
