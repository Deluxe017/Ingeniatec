using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{

    public AudioClip audioFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Muros.instance.Activator();
            AudioSource.PlayClipAtPoint(audioFX, gameObject.transform.position);
        }
    }
}
