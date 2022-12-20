using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLine : MonoBehaviour
{

    GameObject car;


    // Time Component
    private float OriginalTime;
    private float criteriaTime;

    void Start()
    {
        OriginalTime = 0.0f;
        criteriaTime = 1.0f;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OriginalTime += Time.deltaTime;

        if (OriginalTime >= criteriaTime) {
            OriginalTime = 0;
            car = new GameObject("CheckPoint");
            car.tag = "CheckPoint";
            car.transform.position = this.transform.position;
        }
       
    }
}
