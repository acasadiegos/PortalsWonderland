using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorPortales : MonoBehaviour
{

    public static ContadorPortales contadorPortales;
    private int contador;

    void Start()
    {
        contadorPortales = this;

    }
    public void Incrementar()
    {
       contador++;
    }

    public int GetContador()
    {
       return contador;
    }

    public void HacerCero()
    {
        contador = 0;
    }
}
