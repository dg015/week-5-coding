using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCone : MonoBehaviour
{
    public float sightDistance;
    public float visionAngle;

    public GameObject target;
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


        Debug.DrawLine(transform.position, transform.position + leftVector, Color.cyan);
        Debug.DrawLine(transform.position, transform.position + rightVector, Color.cyan);


        if (target != null)
        {
            Vector3 vectorToTarget = target.transform.position - transform.position;

            Debug.DrawLine(transform.position, transform.position + vectorToTarget, Color.green);


            float targetDotProduct = Vector3.Dot(transform.right, vectorToTarget.normalized);
            float visionDotProdcut = Vector3.Dot(transform.right, leftVector.normalized);

            if( targetDotProduct >= visionDotProdcut && vectorToTarget.magnitude <= sightDistance)
            {
                print("target sppoted");
            }
        }
    }

    private void drawVisionCone()
    {


    }

}
