using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DotProductExercise : MonoBehaviour
{

    [SerializeField] private float redAgle;
    [SerializeField] private float blueAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void getVectors()
    {

        float redRads = redAgle * Mathf.Deg2Rad;
        float blueRads = blueAngle * Mathf.Deg2Rad;

        Vector2 redVector = new Vector2(Mathf.Cos(redRads), Mathf.Sin(redRads));

        Debug.DrawLine(Vector2.zero, redVector, Color.red);


        Vector2 blueVector = new Vector2(Mathf.Cos(blueRads), Mathf.Sin(blueRads));

        Debug.DrawLine(Vector2.zero, blueVector, Color.blue);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(Vector3.Dot(redVector, blueVector));

        }
    }

  


    // Update is called once per frame
    void Update()
    {
        getVectors();
    }
}
