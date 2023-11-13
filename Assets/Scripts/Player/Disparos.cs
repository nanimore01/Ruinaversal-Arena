using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{
    Vector3 mousePos;
    public float fireRate = 0.3f;
    [SerializeField]float _currFire;
    public GameObject balas1;
    public Transform DisparosSpawn;

    void Update()
    {
        _currFire += Time.deltaTime;
        mousePos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z);
        Vector3 dir = mousePos - transform.position;
        transform.right = dir;
    }
    
    public void DisparoPorDefecto()
    {
        if(fireRate < _currFire)
        {
            Instantiate(balas1, DisparosSpawn.position, DisparosSpawn.rotation);
            _currFire = 0;
        }
        
    }

}
