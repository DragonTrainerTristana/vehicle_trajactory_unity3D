using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour 
{

    LineRenderer lineRenderer;

    public GameObject[] checkPoint;
    private int count;
    private int lengthOfLineRenderer = 10000;


    private float OriginalTime;
    private float criteriaTime;

    void Start()
    {
        count = 0;
        OriginalTime = 0.0f;

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = .05f;
        lineRenderer.endWidth = .05f;
        lineRenderer.SetVertexCount(lengthOfLineRenderer);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OriginalTime += Time.deltaTime;
        checkPoint = GameObject.FindGameObjectsWithTag("CheckPoint");
        if (checkPoint.Length > 1 && OriginalTime >= criteriaTime) {
            OriginalTime = 0;
            for (int i = count; i < checkPoint.Length - 1; i++) {



                lineRenderer.SetPosition(count, checkPoint[i].transform.position);
                lineRenderer.SetPosition(count + 1, checkPoint[i + 1].transform.position);
                count++;

                //Debug.Log("그림그리기");
                //Debug.DrawLine(checkPoint[i].transform.position, checkPoint[i + 1].transform.position, Color.green);
            }
        }
        
    }
}
