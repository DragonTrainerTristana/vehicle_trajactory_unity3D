using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLine : MonoBehaviour
{

    GameObject car;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        car = new GameObject("CheckPoint");
        car.tag = "CheckPoint";
        car.transform.position = this.transform.position;
    }
}
