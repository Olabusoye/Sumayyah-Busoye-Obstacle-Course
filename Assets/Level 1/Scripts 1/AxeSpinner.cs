using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpinner : MonoBehaviour
{
    [SerializeField] float xSpin = 0;
    [SerializeField] float ySpin = 0;
    [SerializeField] float zSpin = -0.2f;
    void Update()
    {
        transform.Rotate(xSpin, ySpin, zSpin);
        
    }
}
