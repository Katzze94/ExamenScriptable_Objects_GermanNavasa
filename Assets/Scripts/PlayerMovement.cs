using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
   
    public Rigidbody2D rbody;


    void Start()
    {
        
    }

    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),0) *5;
    }
}
