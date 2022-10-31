using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public AudioClip audioFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
             if (collision.gameObject.tag == "Player")
             {
                AudioSource.PlayClipAtPoint(audioFX, gameObject.transform.position);
                     if (audioFX == true)
                      {
                          Destroy(this.gameObject);
                      }
             }
        
    }
}
