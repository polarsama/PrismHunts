using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float velocidadHorizontal = 0.0f;
    [SerializeField] private float speed= 0.0f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento automático horizontal
        //transform.Translate(Vector2.right * velocidadHorizontal * Time.deltaTime);

        // Movimiento del jugador vertical
        float movimientoVertical = Input.GetAxis("Vertical");
        movimiento = new Vector2(0, movimientoVertical);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * speed * Time.deltaTime);
    }
}