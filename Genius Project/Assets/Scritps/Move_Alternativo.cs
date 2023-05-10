using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Alternativo : MonoBehaviour
{
    public SpriteRenderer rederer;
    private Rigidbody2D rb2D;
    private Animator animator;

    [SerializeField] private float movementspeed;

    [SerializeField] private float fuerzaDesalto;

    [SerializeField] private Transform controladorSuelo;

    [SerializeField] private Vector2 dimensionDeCaja;

    [SerializeField] private LayerMask queEsSuelo;

    private bool enSuelo;

    private bool saltar;

    [Range(0, 1)][SerializeField] private float multiplicadorDeSalto;

    [SerializeField] private float multiplicadorDeGravedad;

    private float escalaGravedad;

    private bool botonSaltarArriba;

    public string Scene;



    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        escalaGravedad = rb2D.gravityScale;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            saltar = true;
        }

        if (Input.GetButtonUp("Jump"))
        {
            BotonSaltarArriba();
        }

        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionDeCaja, 0, queEsSuelo);
    }

    private void FixedUpdate()
    {
        if (saltar && botonSaltarArriba && enSuelo)
        {
            Saltar();
        }

        saltar = false;

        if (rb2D.velocity.y < 0 && !enSuelo)
        {
            rb2D.gravityScale = escalaGravedad * multiplicadorDeGravedad;
        }

        else
        {
            rb2D.gravityScale = escalaGravedad;
        }

        if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-movementspeed, rb2D.velocity.y);
            rederer.flipX = true;
        }
        else if (Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(movementspeed, rb2D.velocity.y);
            rederer.flipX = false;
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
    }

    public void Saltar()
    {
        rb2D.AddForce(Vector2.up * fuerzaDesalto, ForceMode2D.Impulse);
        enSuelo = false;
        saltar = false;
        botonSaltarArriba = false;
    }

    private void BotonSaltarArriba()
    {
        if (rb2D.velocity.y > 0)
        {
            rb2D.AddForce(Vector2.down * rb2D.velocity.y * (1 - multiplicadorDeSalto), ForceMode2D.Impulse);
        }

        botonSaltarArriba = true;
        saltar = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionDeCaja);
    }

}
