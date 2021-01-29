using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public static PortalController portal;
    
    private int numeroportal;

    private int rotacion;

    private bool añadido;
    
    void Start()
    {
       portal = this;


       ContadorPortales.contadorPortales.Incrementar();

       
      
      this.numeroportal = ContadorPortales.contadorPortales.GetContador();

      if(numeroportal == 8)
      {
         ContadorPortales.contadorPortales.HacerCero();
      }


      if(numeroportal%2 == 0)
      {
         Destroy(gameObject);
      }
      else{
          Orientacion();
          CambiarColor();
          if(EnlistadorPortales.enlistador.GetCount() == 4)
          {
            EnlistadorPortales.enlistador.EliminarPar();
            EnlistadorPortales.enlistador.EliminarParGO();
          }
          EnlistadorPortales.enlistador.Añadir(portal);
          EnlistadorPortales.enlistador.AñadirGO(gameObject);
          
      }
      
      
         
    }

    void Update()
    {
       if(!EnlistadorPortales.enlistador.Buscar(this))
       {
          Destroy(gameObject);
       }
 
      
    }

    private void Orientacion()
    {
       if(BulletController.bullet.getDireccion().x == 0 && BulletController.bullet.getDireccion().y == -1)
       {
          gameObject.GetComponent<SpriteRenderer>().flipX = false;
          gameObject.transform.eulerAngles = new Vector3(0,0, 90);
          rotacion = 90;
          
       }
       else if(BulletController.bullet.getDireccion().x == 0 && BulletController.bullet.getDireccion().y == 1)
       {
           gameObject.GetComponent<SpriteRenderer>().flipX = true;
           gameObject.transform.eulerAngles = new Vector3(0,0, 90);
           rotacion = 90;
       }
       else if(BulletController.bullet.getDireccion().x == -1 && BulletController.bullet.getDireccion().y ==0){
             gameObject.GetComponent<SpriteRenderer>().flipX = false;
       }
       else
       {
         gameObject.GetComponent<SpriteRenderer>().flipX = true;
       }
    }

    private void CambiarColor()
    {
       if(numeroportal == 5 || numeroportal ==7)
       {
         gameObject.GetComponent<SpriteRenderer>().color = Color.red;
       }


    }

    private void Destruir()
    {
       Destroy(gameObject);
    }

    public int GetRotacion()
    {
       return rotacion;
    }

    
}
