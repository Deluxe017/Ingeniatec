using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MovimientoPlataformas : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private Transform controladorDeSuelo;

    [SerializeField] private float distancia;

    [SerializeField] private bool movimientoDerecha;

    private Rigidbody2D rb2D;

    public string Scene;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        RaycastHit2D informacionSuelo = Physics2D.Raycast(controladorDeSuelo.position, Vector2.down, distancia);
        rb2D.velocity = new Vector2(velocidad, rb2D.velocity.y);

        if(informacionSuelo == false)
        {
            Girar();
        }
    }

    private void Girar()
    {
        movimientoDerecha = !movimientoDerecha;
        transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y + 180, 0f);
        velocidad *= -1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controladorDeSuelo.transform.position, controladorDeSuelo.transform.position + Vector3.down * distancia);
    }
}
