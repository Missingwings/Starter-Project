using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    public AudioClip pickupFlags;

    void OnTriggerEnter2D(Collider2D other)
    {
        Controller controller = other.GetComponent<Controller>();

        if (controller != null)
        {
            if(controller.flags < controller.maxFlags)
            {
                controller.PlaySound(pickupFlags);
                
                controller.ChangeFlags(+1);
                Destroy(gameObject); 
            }
        }

    }
}
