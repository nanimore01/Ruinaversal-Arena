using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PJ : MonoBehaviour
{
    Rigidbody2D playerRB;

    public float velocidad, dashForce, cooldownMeele, CurrCooldownMeele;
    public int vida, vidaMax, golpesRecibidos, parrysHechos, enemigosAsesinados, vidaCuradaPorParry;
    public bool sePuedeMover, seMueve;
    TextoDeVida MedidorDeVida;
    public Text TextoVida;
    public GameObject AtaqueMelee;
    private Vector2 moveInput;
    public Transform TransformPJ;
    private Animator playerAnimator;
    public KeyCode IrAlMenu, ProbarPj;
    public SpawnerDeEnemigos spawnerEnemigos;
    public GameManager GM;
    AudioSource aS;


    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        spawnerEnemigos = GameObject.Find("SpawnerDeEnemigos").GetComponent<SpawnerDeEnemigos>();
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        vida = GM.vidaMax;
        velocidad = GM.speed;
        vidaCuradaPorParry = GM.vidaCuradaPorParry;
        aS = GetComponent<AudioSource>();
       
    }

    void Awake()
    {
        
        
        
        
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(ProbarPj))
        {
            sePuedeMover = true;
        }
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

        if(moveX != 0 || moveY != 0)
        {
            seMueve = true;
        }
        else
        {
            seMueve = false;
        }
        
        CurrCooldownMeele += Time.deltaTime;
        

        if (Input.GetMouseButton(0) && CurrCooldownMeele > cooldownMeele && sePuedeMover == true)
        {
            Instantiate(AtaqueMelee, TransformPJ.position, TransformPJ.rotation);
            CurrCooldownMeele = 0;
        }
        
        if(Input.GetKeyDown(IrAlMenu))
        {
            SceneManager.LoadScene(0);
        }

        playerAnimator.SetFloat("Horizontal", moveX);
        playerAnimator.SetFloat("Vertical", moveY);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

        Morir();

        //if(enemigosAsesinados == spawnerEnemigos.enemigosEnEscenaMax)
        {
          //  SceneManager.LoadScene(5);
          //  GM.hordas++;
        }

      
    }

    void FixedUpdate()
    {
        
        
        
        if (sePuedeMover == true)
        {
            playerRB.MovePosition(playerRB.position + moveInput * velocidad * Time.fixedDeltaTime);
            
        }
        

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("BalaEnemiga"))
        {
            
            GM.golpesRecibidos++;
            aS.Play();
        }
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            
            GM.golpesRecibidos++;
            aS.Play();

        }
        
    }

   

    public void ParryCuraVida()
    {
        
        if(vida < GM.vidaMax)
        {
            vida += GM.vidaCuradaPorParry;
        }
        parrysHechos++;
    }

    public void Morir()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene(0);
            GM.hordas = 1;
            GM.golpesRecibidos = 0;


        }
    }
    
    
}
