using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    private static int score;
    public Text Texto;
  
    void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        Texto.text = "Score: " + score;
    }

// Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
