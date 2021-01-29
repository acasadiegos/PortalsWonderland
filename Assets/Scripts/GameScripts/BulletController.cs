using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    private Vector2 direccion;
    public GameObject PortalPrefab;

    public static BulletController bullet;
    private float _speed;

    private int numero;
    void Start()
    {
        this.direccion = PlayerMovement.playermov.getPointAxis();
        this._speed = 3f;
        bullet = this;

    }

    // Update is called once per frame
    void Update()
    {


           transform.position += new Vector3(direccion.x * Time.deltaTime * _speed, direccion.y * Time.deltaTime * _speed, 0);

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Acid" || collision.transform.tag == "Pua" || collision.transform.tag == "AntiPortal" || collision.transform.tag == "Electricity" || collision.transform.tag == "Portal")
        {

            Destroy(gameObject);
        }
        else if (collision.transform.tag == "Plataforma")
        {
            Quaternion rotation = new Quaternion();
            Instantiate(PortalPrefab, transform.position, rotation);
            Destroy(gameObject);
        }
    }

    public Vector2 getDireccion()
    {
        return direccion;
    }
}
