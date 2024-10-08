using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCone : MonoBehaviour
{
    public float sightDistance;
    public float visionAngle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleInRdas = visionAngle * Mathf.Deg2Rad;

        Vector3 leftVector = new Vector3(Mathf.Cos(angleInRdas), Mathf.Sin(angleInRdas), 0) * sightDistance;
        Vector3 rightVector = new Vector3(Mathf.Cos(-angleInRdas), Mathf.Sin(-angleInRdas), 0) * sightDistance;

        

    }
}
