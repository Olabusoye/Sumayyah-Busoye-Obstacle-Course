using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRend;
    Rigidbody rb;
    [SerializeField] float timeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        mRend = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
        mRend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if( Time.time > timeToWait)
        {
            rb.useGravity = true;
            mRend.enabled = true;
        }
    }


}
