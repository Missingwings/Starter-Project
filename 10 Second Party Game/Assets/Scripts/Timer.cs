using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public float timer = 0f;  
   Text timerText;

   public GameObject controller;

   
    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    void GetObjects()
    {       
         controller = gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = "Timer: " + Mathf.Round(timer);
    }

}
