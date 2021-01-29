using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunicionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.tag == "Player" && ScoreManager.score.GetScorePlayer1() <4)
         {
             ScoreManager.score.RaiseScorePlayer1(1);
             MunicionSpawner.municionSpawner.CreateMunicion();
             Destroy(gameObject);
         }
    }
}
