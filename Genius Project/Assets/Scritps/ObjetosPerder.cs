using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetosPerder : MonoBehaviour
{
    public string Scene_ = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
            {
            SceneManager.LoadScene(this.Scene_);
            }
    }
}
  