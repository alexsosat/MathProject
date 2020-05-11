using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    float tiempo_Turno = 10f;
    float tiempo_actual;

    public Text countdown;

    public static bool turn = true;
    public Move Player1;
    public Move Player2;

    void Start()
    {
        tiempo_actual = tiempo_Turno;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_actual -= 1 * Time.deltaTime;
        countdown.text = ((int)tiempo_actual).ToString();
        if ((int)tiempo_actual <= 0)
        {
            turn = !turn;
            cambioTurno();
            bala.disparo = false;
            tiempo_actual = tiempo_Turno;
        }
    }

    public void cambioTurno()
    {
        if (turn)
        {
            Player1.enabled = true;
            Player2.enabled = false;
        }
        else
        {
            Player2.enabled = true;
            Player1.enabled = false;
        }

    }
}
