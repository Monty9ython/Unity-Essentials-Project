using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject player;

    

    private void Start()
    {
        scoreText.text = "Hello World";
    }

    private void Update()
    {
       
    }
   


}
