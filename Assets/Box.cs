﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Box : MonoBehaviour
{
    public Text scoretext;
    int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vegitable.Type typeA = GetComponent<Vegitable>().type;
        Vegitable.Type typeB = other.GetComponent<Vegitable>().type;
        if(typeA == typeB)
        {
            score++;
            scoretext.text = score.ToString();
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
