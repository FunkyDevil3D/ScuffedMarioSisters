using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHribik : MonoBehaviour
{

    public bool Invincible;
    public bool Active;
    public float timePassed;
    public float maxTime;
    public GameObject hribik;

    // Start is called before the first frame update
    void Start()
    {
        Active = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "hubicka")
        {
            Invincible = true;
            
        }
        timePassed = 0;
        GameObject hribik = collision.gameObject;
        Destroy(hribik);

        
    }

    public void Timer()
    {
        if (Invincible)
        {
            timePassed += Time.deltaTime;

            if (timePassed > maxTime)
            {
                Invincible = false;
                Active = true;
            }
        }
        
    }

   



}
