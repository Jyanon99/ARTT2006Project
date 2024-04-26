using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public AudioSource knockSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            knockSound.Play();
        }
        else 
        { 
            knockSound.Pause();
        }
    }
}
