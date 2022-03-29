using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Vector3 direction;
    [SerializeField] private bool jumpKeyWasPressed;
    public float jumpForce;
    void Start()
    {
        var speed = direction * Speed * Time.deltaTime;
    }
    void Update()
    {   
        direction.x = Input.GetAxis("Horizontal");
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
      
    }

    private void FixedUpdate()
    {
        var speed = direction * Speed * Time.deltaTime;
        
        transform.Translate(speed);
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }
}
