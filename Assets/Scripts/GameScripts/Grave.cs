using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour
{
    private float tiempoauxiliar;
    private float tiempodepartida;
    private float rotacion;

    private float tiempodecambio;



    public static Grave _grave;

    void Start()
    {
          _grave = this;
          tiempodecambio = 20;
    }
    

    // Update is called once per frame
    void Update()
    {
         tiempoauxiliar += Time.deltaTime;
         tiempodepartida += Time.deltaTime;
         if(tiempodepartida > 60 && tiempodecambio != 4)
         {
               tiempodecambio -= 4;
               tiempodepartida = 0;
         }

         gameObject.transform.eulerAngles = new Vector3(0,0,rotacion);
         int orientacion = Random.Range(0,4);


        if(tiempoauxiliar > tiempodecambio){

              AlarmaSoundController.alarmasound.SoundOn();

            switch(orientacion)
            {
               case 0:
                    Physics2D.gravity = new Vector2(-9.81f, 0f);
                    rotacion = 270;
                    gameObject.GetComponent<SpriteRenderer>().flipY = false;
                    break;

              case 1:
                    Physics2D.gravity = new Vector2(9.81f, 0f);
                    rotacion = 90;
                    gameObject.GetComponent<SpriteRenderer>().flipY = false;
                    break;

              case 2:
                    Physics2D.gravity = new Vector2(0, 9.81f);
                    rotacion = 180;
                    
                    
                    break;

             case 3:
                    Physics2D.gravity = new Vector2(0, -9.81f);
                    rotacion = 0;
                    gameObject.GetComponent<SpriteRenderer>().flipY = false;
                    break;

            }

            tiempoauxiliar = 0;
       }
    }

    public float getrotacion()
    {
          return rotacion;
    }
}
