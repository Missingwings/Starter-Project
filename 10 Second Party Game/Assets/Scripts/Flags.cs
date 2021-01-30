using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Controller controller = other.GetComponent<Controller>();

        if (controller != null)
        {
            controller.ChangeFlags(1);
            Destroy(gameObject);
        }

    }
}
