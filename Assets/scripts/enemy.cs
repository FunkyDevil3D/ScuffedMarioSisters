using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    Rigidbody2D rb;
    public float timePassed = 0;
    public float maxTime = 3;
    public bool movingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        timePassed = maxTime;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if(timePassed > maxTime)
        {
            timePassed = 0;
            if (movingRight)
            {
                movingRight = false;
                rb.velocity = new Vector2(-4, 0);
            }
            else
            {
                movingRight = true;
                rb.velocity = new Vector2(4,0);
            }
        }
        



        
        
                
    }
    

}
