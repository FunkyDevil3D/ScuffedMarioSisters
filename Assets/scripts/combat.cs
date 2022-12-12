using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
    Rigidbody2D rb;
    
    PlayerMovement pm;
    PowerUpHribik pu;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pm = GetComponent<PlayerMovement>();
        pu = GetComponent<PowerUpHribik>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        Debug.Log(velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject enemy = collision.gameObject;
        if (collision.collider.tag == "enemy")
        {
            Vector2 velocity = rb.velocity;

            if (pu.Invincible == true)
            {
                Destroy(enemy);
            }
            else if (velocity.y < enemy.GetComponent<Rigidbody2D>().velocity.y)
            {
                
                Debug.Log("colisia");
                Destroy(enemy);
            }
            else 
            {
                
                Debug.Log("colisia");
                Destroy(this.gameObject);
            }
        }
    }


}
