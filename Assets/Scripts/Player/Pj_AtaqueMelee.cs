using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pj_AtaqueMelee : MonoBehaviour 
{
    public Transform pJ;
    public GameObject balas1;
    public float fireRate = 1f;
    private float _currFire;

    public void Update()
    {
        _currFire += Time.deltaTime;
    }

    public void AtaqueMelee ()
    {
        if (fireRate < _currFire)
        {
            Instantiate(balas1, pJ.position, pJ.rotation);
            _currFire = 0;
        }
    }
    
}
