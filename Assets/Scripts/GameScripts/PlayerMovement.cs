using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement playermov;
    private Controls _controls;
    private float _speed;

    private float _jumpforce;
    private Vector2 _moveAxis;

    private Vector2 _pointaxis;

    private bool canjump;

    private float agonytime;

    private bool playerdeath;

    private bool touchsofttrap;

    private float shoottime;

   private float unidadescorrecion;

    private Animator _animator;
    void Awake()
    {
      _controls = new Controls();
      _animator = gameObject.GetComponent<Animator>();
      _speed = 1f;
      _jumpforce = 100f;
      agonytime = 0f;
      shoottime = 3f;
      unidadescorrecion = 0.4f;



    }

    void Start()
    {
        playermov = this;
    }
    private void OnEnable()
    {
       
       _controls.Player.Walk.performed += HandleWalk;
       _controls.Player.Walk.Enable();

       _controls.Player.Jump.performed += HandleJump;
       _controls.Player.Jump.Enable();

       _controls.Player.Point.performed += HandlePoint;
       _controls.Player.Point.Enable(); 

       _controls.Player.Shoot.performed += HandleShoot;
       _controls.Player.Shoot.Enable();

 

       
    }

    private void OnDisable()
    {
       _controls.Player.Walk.performed -= HandleWalk;
       _controls.Player.Walk.Disable();

       _controls.Player.Jump.performed -= HandleJump;
       _controls.Player.Jump.Disable();

       _controls.Player.Point.performed -= HandlePoint;
       _controls.Player.Point.Disable(); 

       _controls.Player.Shoot.performed -= HandleShoot;
       _controls.Player.Shoot.Disable();

       
    }

    private void Update()
    {
       
        if(agonytime > 3 && playerdeath)
         {
            ElectricitySoundController.electricitysound.SoundOff();
            Destroy(gameObject);
         }
         else if(agonytime > 1 && touchsofttrap)
         {
            Death();
         }
         

         if(!playerdeath)
         {
            Mover();
         }

        agonytime += Time.deltaTime;
        shoottime += Time.deltaTime;


        
    }

    private void Mover()
    {
       if(Grave._grave.getrotacion() == 0  ||  Grave._grave.getrotacion() == 180)
        {
        transform.position += new Vector3(_moveAxis.x * Time.deltaTime * _speed, 0, 0);
        }
        else if(Grave._grave.getrotacion() == 90)
        {
           transform.position += new Vector3(0, _moveAxis.x * Time.deltaTime * _speed, 0);
        }
        else
        {
           transform.position += new Vector3(0, -_moveAxis.x * Time.deltaTime * _speed, 0);
        }
    }
    

    private void HandleWalk(InputAction.CallbackContext context)
    {
       if(!playerdeath)
       {
        _moveAxis = context.ReadValue<Vector2>();
        CambiarMovimiento();

      }
        
    }

    private void HandlePoint(InputAction.CallbackContext context)
    {
       if(!playerdeath){

         _pointaxis = context.ReadValue<Vector2>();


       }
    }

    private void HandleShoot(InputAction.CallbackContext context)
    {

       if((_pointaxis.x !=0  || _pointaxis.y!=0) && shoottime>2f && ScoreManager.score.GetScorePlayer1() > 0)
       {
         _animator.SetTrigger("runningshoot");
         BulletSpwaner.bulletspawner.CreateBullet();
         shoottime = 0f;
         ScoreManager.score.DecreaseScorePlayer1();
         
       }
        
       
    }

    private void HandleJump(InputAction.CallbackContext context)
    {
       if(canjump && !playerdeath)
       {
          
          _animator.SetBool("jumping",true);
          RunSoundController.runsound.SoundOff();
           JumpSoundController.jumpsound.SoundOn();
           
         if(Grave._grave.getrotacion() == 0)
         {
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, _jumpforce));
         }
         else if(Grave._grave.getrotacion() == 270)
         {
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(_jumpforce, 0));
         }
         else if(Grave._grave.getrotacion() == 90)
         {
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-_jumpforce, 0));
         }
         else
         {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -_jumpforce));
         }

         canjump = false;
         
       }

       
    }



    private void CambiarMovimiento()
    {
        if(_moveAxis.x != 0f)
        {
          _animator.SetBool("running", true);
          RunSoundController.runsound.SoundOn();
           if(Grave._grave.getrotacion() == 180)
           {
              if(_moveAxis.x <0)
                {
                   gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
             else
                {
                   gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
           }
           else{
                if(_moveAxis.x <0)
                {
                   gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {
                   gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
              }
        
        }
        else{
           _animator.SetBool("running", false); 
           RunSoundController.runsound.SoundOff();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Acid" || collision.transform.tag == "Pua")
        {
            canjump = false;
            _animator.SetBool("jumping",false);
            if(collision.transform.tag == "Acid")
            {
               BubblesSoundController.bubblessound.SoundOn();
            }
            else
            {
               PuaSoundController.puasound.SoundOn();
            }
            Death();

            
            
            
        }
        else if(collision.transform.tag == "Electricity")
        {
           touchsofttrap = true;
           _speed = 0.3f;
            canjump = false;
            _animator.SetBool("jumping",false);
             agonytime = 0f;
            ElectricitySoundController.electricitysound.SoundOn();
             
           
        }
        else if (collision.transform.tag == "Plataforma" || collision.transform.tag == "AntiPortal")
        {
           canjump = true;
           _animator.SetBool("jumping",false);
           touchsofttrap = false;
           _speed = 1f;
           ElectricitySoundController.electricitysound.SoundOff();
          
        }
        else if (collision.transform.tag == "Portal")
        {
           
           int posicion = EnlistadorPortales.enlistador.ObtenerPos(collision);
           
           if(posicion%2 == 0)
           {
              try{
                  posicion = posicion+1;
                   gameObject.transform.position = EnlistadorPortales.enlistador.ObtenerTrans(posicion);
              }
              catch{
                   Debug.Log("Aprenda a programar");
              }
           }
           else
           {
              posicion = posicion-1;
              gameObject.transform.position = EnlistadorPortales.enlistador.ObtenerTrans(posicion);
              
           }

           GameObject portalOBsiguiente = EnlistadorPortales.enlistador.ObtenerObjeto(posicion);
           PortalController  portalsiguiente = EnlistadorPortales.enlistador.Obtener(posicion);


          try{
               if(portalsiguiente.GetRotacion() == 0 && portalOBsiguiente.GetComponent<SpriteRenderer>().flipX == false )
               {
                 gameObject.transform.position += new Vector3(unidadescorrecion,0,0);
               }
               else if(portalsiguiente.GetRotacion() == 0 && portalOBsiguiente.GetComponent<SpriteRenderer>().flipX == true)
               {
                  gameObject.transform.position += new Vector3(-unidadescorrecion,0,0);
               }
               else if(portalsiguiente.GetRotacion() == 90 && portalOBsiguiente.GetComponent<SpriteRenderer>().flipX == true)
               {
                  gameObject.transform.position += new Vector3(0,-unidadescorrecion,0);
              
               }
               else if(portalsiguiente.GetRotacion() == 90 && portalOBsiguiente.GetComponent<SpriteRenderer>().flipX == false){
                  gameObject.transform.position += new Vector3(0 ,unidadescorrecion,0);
      
               }
          }
          catch
          {

          }
          


        }
        
 
    }

    private void Death()
    {
       _animator.SetTrigger("dying");

            if(playerdeath == false)
            {
              playerdeath = true;
              RunSoundController.runsound.SoundOff();
              agonytime = 0f;
             

            }
    }

    public Vector2 getPointAxis()
    {
       return _pointaxis;
    }

    public Vector2 getPlayerPos()
    {
       return transform.position;
    }

    
}
