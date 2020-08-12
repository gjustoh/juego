using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
  public Text Tempo;
    public float Tiempo = 0.0f;
    public bool DebeAumentar = false;

    void Update()
    {
        // Se comprueba si debe aumentar el valor primero...
        DebeAumentar = (Tiempo <= 0.0f)  ? true : false;

        // Luego se efectua el aumento.
        if (DebeAumentar) Tiempo += Time.deltaTime;
        else Tiempo -= Time.deltaTime;

        // Se asigna el color dependiendo del tiempo restante.
        Tempo.color  = (Tiempo <= 30.0f) ? Color.red : Color.green;

        Tempo.text = "Tiempo:" + " " + Tiempo.ToString ("f0");
    }
}
