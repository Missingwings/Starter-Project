using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float speed = 3.0f;
    public float timer = 0f;
    
    public int maxFlags = 5;
    public int flags { get { return currentFlags; }}
    int currentFlags;

    public Text winText;
    public Text loseText;
    public Text collectFlags;

    // Start is called before the first frame update
    void Start()
    {
        currentFlags = 0;
        FlagPickup();

        winText.text = "";
        loseText.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

        if (Input.GetKey(KeyCode.A))
        {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

        if (Input.GetKey(KeyCode.S))
        {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

        if (Input.GetKey(KeyCode.D))
        {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

        if (timer >= 10f)
        {
            if(currentFlags < 5)
            {
                loseText.text = "You lose.";               
                Destroy (gameObject);
            }
            if (currentFlags >= 5)
            {
                winText.text = "~Congratulations! You win!~";
            }
        }

    }

    public void ChangeFlags (int amount)
    {
        currentFlags = Mathf.Clamp(currentFlags + amount, 0, maxFlags);
        FlagPickup();
    }

    void FlagPickup()
    {
        collectFlags.text = "Flags: " + currentFlags.ToString();
    }

   // void LoseGame()
   // {
    
   // }
}
