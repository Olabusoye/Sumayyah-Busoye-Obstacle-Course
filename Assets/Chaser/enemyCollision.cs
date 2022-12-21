using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{


    private bool caught = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("you've been caught :( ");
            caught = true;
            // FindObjectOfType<GameManager>().EndGame();

            
        }
            
        
    }
}