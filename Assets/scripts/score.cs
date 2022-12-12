using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{

    public TMP_Text scoretext;
    public float counter;
    public float scorespeed;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime * scorespeed;
        scoretext.text = "Score:" + counter.ToString("0");
        
    }


   

}
