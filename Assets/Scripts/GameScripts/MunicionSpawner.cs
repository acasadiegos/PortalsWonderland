using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunicionSpawner : MonoBehaviour
{
    public GameObject MunicionPrefab;

    private List<Vector3> posiciones;
    public static MunicionSpawner municionSpawner;
    void Start()
    {
        municionSpawner = this;
        posiciones = new List<Vector3>();
        AñadirPosiciones();
        CreateMunicion();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateMunicion()
    {
        Quaternion rotation = new Quaternion();
        Instantiate(MunicionPrefab, posiciones[Random.Range(0,7)], rotation);
    }

    private void AñadirPosiciones()
    {
        posiciones.Add(new Vector3(-2.62f,1.28f,0));
        posiciones.Add(new Vector3(-1.19f,2.17f,0));
        posiciones.Add(new Vector3(-0.17f,0.87f,0));
        posiciones.Add(new Vector3(1.47f,-1.75f,0));
        posiciones.Add(new Vector3(4.57f,2.3f,0));
        posiciones.Add(new Vector3(-5.91f,-1.43f,0));
        posiciones.Add(new Vector3(3.25f,-0.32f,0));
    }
}
