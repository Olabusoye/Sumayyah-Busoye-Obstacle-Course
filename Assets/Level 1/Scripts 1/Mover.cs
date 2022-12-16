using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] int moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovement();
    }

    void PrintInstructions (){

        Debug.Log("Welcome to the Game");
        Debug.Log("Move your player with W,A,S,D or the arrow keys");
        Debug.Log("Don't hit the walls!!"); 

    }

    void PlayerMovement (){

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);

    }
}
