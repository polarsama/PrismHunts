using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadHorizontal = 3f;
    public float velocidadVertical = 5f;

    void Update()
    {
        // Movimiento automático horizontal
        transform.Translate(Vector2.right * velocidadHorizontal * Time.deltaTime);

        // Movimiento del jugador vertical
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(0f, movimientoVertical);
        transform.Translate(movimiento * velocidadVertical * Time.deltaTime);
    }
}