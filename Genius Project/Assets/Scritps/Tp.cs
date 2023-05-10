using UnityEngine;
using UnityEngine.SceneManagement;


public class Tp : MonoBehaviour
{
    public string win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(this.win);
        }       
    }
}
