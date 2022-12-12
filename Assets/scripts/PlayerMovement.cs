using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1;
    public float jumpForce = 1;
    private Rigidbody2D rb;
    public bool jump;
    PowerUpHribik pu;
    public float StartSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = false;
        pu = GetComponent<PowerUpHribik>();
        StartSpeed = movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        pu.Timer();


        if (pu.Invincible && pu.Active == false)
        {
            movementSpeed = movementSpeed * 2f;
            pu.Active = true;
            
        }
        else if(pu.timePassed >= pu.maxTime)
        {

            movementSpeed = movementSpeed / 2f;
            pu.timePassed = 0;
            pu.Active = false;
        }
        
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if(!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if(Input.GetButton("Jump") && Mathf.Abs(rb.velocity.y) < 0.001)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jump = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "floor")
        {
            jump = false;
        }
    }




}
