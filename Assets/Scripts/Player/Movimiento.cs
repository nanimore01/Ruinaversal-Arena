using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento
{
    
    float _velocidad;
    
    public Transform _transform;
    

    public Movimiento(Transform transform, float velocidad)
    {
        _transform = transform;
        _velocidad = velocidad;
    }

    public void Move(float moveX, float moveY)
    {
        Vector3 dir = _transform.up * moveX;
        dir += _transform.right * moveY;

        _transform.position += dir.normalized * _velocidad * Time.deltaTime;
    }

    
}
