using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{


    public static BulletSpwaner bulletspawner;


    public GameObject BulletPrefab;
    
    private int contador;

    void Start()
    {

        bulletspawner = this;

    }

    // Update is called once per frame
    public void CreateBullet()
    {
        contador++;
        Quaternion rotation = new Quaternion();
        Instantiate(BulletPrefab, PlayerMovement.playermov.getPlayerPos() , rotation);
  
     
    }

    public int getContador()
    {
        return contador;
    }


}
