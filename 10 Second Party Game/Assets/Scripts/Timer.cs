using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public float timer = 0f;  
   public Text loseText;

   Text timerText;

   public GameObject controller;

   
    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
        
        loseText.text = "";
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
            
                if (timer >= 10f)
                {
                        loseText.text = "You lose.";
                        Destroy (controller);
                }
    }

}
