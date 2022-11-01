using UnityEngine;
using UnityEngine.SceneManagement;


public class Tp : MonoBehaviour
{
    public string win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(this.win);
    }
}
