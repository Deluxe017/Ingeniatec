using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
    private float horizontalMove = 0f;
    private float verticalalMove = 0f;

    public Joystick joystick;

    public float runSpeedHorizontal = 2;
    public float runSpeed = 1.25f;
    public float jumpSpeed = 2f;

    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;


    [Header("Salto")]
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool enSuelo;

    public AudioClip audioFX;

    private bool Salto = false;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (horizontalMove > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    public void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;


        //enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);

        //Mover(movimientoHorizontal * Time.fixedDeltaTime, Salto);

        //Salto = false;
    }

    /*public void Jump() 
    {
        Salto = true;
        AudioSource.PlayClipAtPoint(audioFX, gameObject.transform.position);
        

    }*/
}
