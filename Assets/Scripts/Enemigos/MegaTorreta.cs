using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaTorreta : EnemigosBase
{
    [Header("Values de Mega Torreta")]
    [SerializeField] tipoDeBala _tipoDeBala;
    [SerializeField] float _fireRate;
    [SerializeField] Ray2D _disparo;
    [SerializeField] GameObject[] _balas;
    [SerializeField] GameObject _balaAdisparar;
    [SerializeField] float _rotationSpeed;
    [SerializeField] Transform _puntaDeCanon;
    [SerializeField] float _distanciaMax;
    RaycastHit2D _hit;
    bool _canShot = true;
    
    
    void Start()
    {
        _vida = vidaMax;
        TipoDeBala(_tipoDeBala);
        _nombreEnemigo = "Mega Torreta";
    }
    void Update()
    {
        Disparo();
        Movimiento();
        
    }

    void Disparo()
    {
        
        _disparo = new Ray2D(_puntaDeCanon.transform.position, _puntaDeCanon.right);
        _hit = Physics2D.Raycast(_disparo.origin, _disparo.direction, _distanciaMax);
        Debug.DrawRay(_disparo.origin, _disparo.direction * _distanciaMax);
        if(_hit && _canShot)
        {
            if(_hit.collider.GetComponent<Personaje>())
            {
                Debug.Log("Te detecto");
                Instantiate(_balaAdisparar, _puntaDeCanon.transform.position, _puntaDeCanon.transform.rotation);
                StartCoroutine(Reloading());
            }
        }
    }

    void Movimiento()
    {
        
        if( _canShot)
        {
            transform.Rotate(new Vector3(0f, 0f, _rotationSpeed * Time.deltaTime));
        }
        
    }

    public override void RecibirDano(int Dano)
    {
        base.RecibirDano(Dano);
        print(Dano);
        _tipoDeBala++;
        TipoDeBala(_tipoDeBala);
        
    }
    void TipoDeBala(tipoDeBala e)
    {
        _balaAdisparar = _balas[(int)e];
    }

    

    IEnumerator Reloading()
    {
        _canShot = !_canShot;
        yield return new WaitForSeconds(_fireRate);
        _canShot = !_canShot;
    }
    public enum tipoDeBala
    {
        normal = 0,
        defuego = 1,
        deTierra = 2,
        deAgua = 3,
    }

    
}
