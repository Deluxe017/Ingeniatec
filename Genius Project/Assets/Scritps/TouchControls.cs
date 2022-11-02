using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))]
public class TouchControls : MonoBehaviour
{
    public Move move;
    Vector2 startX;
    float moveDir;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touches.Length; i++)
            {
                if(Input.GetTouch(i).position.x < (float)Screen.width/2f)
                {
                    if(Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        startX = Input.GetTouch(i).position;
                    }

                    if(Input.GetTouch(i).phase == TouchPhase.Moved)
                    {
                        Vector3 moveDir =  startX - Input.GetTouch(i).position;
                        moveDir = moveDir.normalized;
                        move.joystickValue = moveDir.x *= -1;
                    }

                    if(Input.GetTouch(i).phase == TouchPhase.Ended)
                    {
                        move.joystickValue = 0;
                    }
                }
                else
                {
                    if(Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        OnJump();
                    }
                }
            }
        }
    }

    private void OnMove()
    {

    }

    private void OnJump()
    {
        move.Salto = true;
    }
}
