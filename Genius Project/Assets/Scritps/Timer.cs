using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    //entero para tener los minuto y segundos
    public int min, seg;

    //variable apra el text mesh pro del tiempo
    public TMP_Text tiempo;

    //flotante para calcular el tiempo restante que tiene el jugador 
    public float restante;

    //booleano que avisa si el relog esta en marcha o no
    public bool enMarcha;


    private void Awake()
    {
        //calculo el restante que tiene el jugador, coon una formula que tiene los minutos y segundos
        restante = (min * 60) + seg;
    }

    void Update()
    {
        //condicional que funciona si esta en marcha es verdadero
        if (enMarcha)
        {
            //Cambiar el simbolo de + a - si quieres hacer que el contador vaya hacia atras en vez de hacia adelante
            restante += Time.deltaTime;

            //aqui convierto a entero lel temporizados en minutos y segundos basados en el restante
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);

            //mando el tiempo como un string para poder mostrarlo en pantalla
            tiempo.text = string.Format("{00:00} : {01:00}", tempMin, tempSeg);
        }
    }
}
