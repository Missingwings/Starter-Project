using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        Controller controller = other.GetComponent<Controller>();

        if (controller != null)
        {
            if(controller.flags < controller.maxFlags)
            {
                controller.ChangeFlags(+1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }

    }
}
