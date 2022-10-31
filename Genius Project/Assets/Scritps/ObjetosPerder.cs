using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetosPerder : MonoBehaviour
{
    public string Scene_ = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(this.Scene_);
    }
}
  