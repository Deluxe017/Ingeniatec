using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Nivel2");
    }
}
