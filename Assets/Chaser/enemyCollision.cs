using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    private bool caught = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy" && !caught)
        {
            Debug.Log("you've been caught :( ");
            caught = true;
            FindObjectOfType<GameManager>().RestartLevel();
        }
        
         if (collision.gameObject.tag == "nextLevelPlane")
        {
            Debug.Log("next level :) ");
            FindObjectOfType<GameManager>().NextLevel();
        }
    }
}
