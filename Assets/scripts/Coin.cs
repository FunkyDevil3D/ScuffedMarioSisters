using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    public TMP_Text coinText;
    private float coin;

    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<TMP_Text>();
        
        
        
    }

    private void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Coin")
        {
            coinText.text = "Coins: " + coin;
            
            
            
        }
    }

    


}
