using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlistadorPortales : MonoBehaviour
{
    public static EnlistadorPortales enlistador;

    private List<PortalController> listaPortales;

    private List<GameObject> listaGOPortales;

    void Start()
    {
        enlistador = this;
        listaPortales = new List<PortalController>();
        listaGOPortales = new List<GameObject>();
    }

    // Update is called once per frame
    public void Añadir(PortalController portal)
    {
       listaPortales.Add(portal);

    
    
    }

    public void AñadirGO(GameObject portalOB)
    {
       listaGOPortales.Add(portalOB);
       Debug.Log("Añadido");
    
    
    }


    public int GetCount()
    {
       return listaPortales.Count;
    }

    public void EliminarPar()
    {
        listaPortales.RemoveAt(0);
        listaPortales.RemoveAt(0);
    }

    public void EliminarParGO()
    {
        listaGOPortales.RemoveAt(0);
        listaGOPortales.RemoveAt(0);
    }

    public bool Buscar(PortalController portal)
    {
       bool encontrado = false;

       for(int i = 0; i<listaPortales.Count; i++)
       {
           if(portal == listaPortales[i])
           {
               encontrado = true;
           }
       }


       return encontrado;
    }

    public bool BuscarGO(PortalController portalGO)
    {
       bool encontrado = false;

       for(int i = 0; i<listaGOPortales.Count; i++)
       {
           if(portalGO == listaGOPortales[i])
           {
               encontrado = true;
           }
       }


       return encontrado;
    }

    public int ObtenerPos(Collision2D collision)
    {
       int posicion = 0;

       for(int i=0; i<listaGOPortales.Count;i++)
       {
           if(collision.transform == listaGOPortales[i].transform)
           {
              posicion = i;
           }
       }

       return posicion;
    }

    public Vector3 ObtenerTrans(int posicion)
    {
       return listaGOPortales[posicion].transform.position;
    }

    public GameObject ObtenerObjeto(int posicion)
    {
        return listaGOPortales[posicion];
    }

    public PortalController Obtener(int posicion)
    {
        return listaPortales[posicion];
    }



    
}
