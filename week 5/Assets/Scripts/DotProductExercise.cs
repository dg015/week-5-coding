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
        Vector2 redVector = new Vector2(Mathf.Cos(redAgle), Mathf.Sin(redAgle));

        Debug.DrawLine(redVector, new Vector2(redVector.x + 1, redVector.y + 1), Color.red);


        Vector2 blueVector = new Vector2(Mathf.Cos(blueAngle), Mathf.Sin(blueAngle));

        Debug.DrawLine(blueVector, new Vector2(blueVector.x + 1, blueVector.y + 1), Color.blue);
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
