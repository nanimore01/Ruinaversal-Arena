using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoCamara : MonoBehaviour
{
    
    public GameObject target;
    private Vector3 targetPos;
    public float haciaDelante;
    public float smoothing;

    private void FixedUpdate()
    {
        targetPos = new Vector3(target.transform.position.x, target.transform.position.y, z: -10);

        if (target.transform.localScale.x == 1)
        {
            targetPos = new Vector3(targetPos.x + haciaDelante, targetPos.y, z: -10);
        }

        if (target.transform.localScale.x == -1)
        {
            targetPos = new Vector3(targetPos.x - haciaDelante, targetPos.y, z: -10);
        }

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing * Time.fixedDeltaTime);

    }
}
