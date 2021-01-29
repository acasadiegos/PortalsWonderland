using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    void OntriggerEnter2D(Collider2D other){
        Debug.Log(other.tag);
    }
}
