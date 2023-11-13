using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoBasico : EnemigosBase
{
    public bool seMueve;
    float currSpeed;
    private Animator playerAnimator;
    

    // Start is called before the first frame update
    private void Awake()
    {
        PlayerPos = Personaje.PJ.transform;
        playerAnimator = GetComponent<Animator>();
        aS = GetComponent<AudioSource>();
        _nombreEnemigo = "Enemigo Basico";
    }

    void Start()
    {
        currSpeed = velocidad;
        _vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(PlayerPos.position, transform.position) < viewDistance) && sePuedeMover == true)
        {
            Vector3 dir = (PlayerPos.position - transform.position).normalized;
            transform.position += dir * currSpeed * Time.deltaTime;
            seMueve = true;
        }
        else
        {
            seMueve = false;
        }

        //playerAnimator.SetBool("SeMueve", seMueve);
    }

   

    

    private void OnTriggerEnter2D(Collider2D AtaqueMeleePJ)
    {
       
        if (AtaqueMeleePJ.gameObject.CompareTag("Player"))
        {
            AtaqueMeleePJ.GetComponent<Personaje>().RecibirDano(dano);
        }
    }
}
