using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenioStatic : MonoBehaviour
{
    #region variables
    [SerializeField] private float frequency;
    [SerializeField] private float magnitude;
    [SerializeField] private Vector3 offset_Y;
   // private Vector3 desirePosition;
    #endregion

    private void Start()
    {
        transform.position = transform.localPosition;
    }

    private void Update()
    {
        transform.localPosition = (transform.position + transform.up * (Mathf.Sin(Time.time * frequency) * magnitude) + offset_Y);
    }
}