using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorAsteroides : MonoBehaviour
{
    public GameObject asteroidePrefab;
    public float velocidadAsteroides = 0f;
    public float frecuenciaGeneracion = 0f;
    public int cantidadMinima = 0;
    public int cantidadMaxima = 0;

    void Start()
    {
        // Iniciar la generación de asteroides
        //InvokeRepeating("GenerarAsteroide", 0f, frecuenciaGeneracion);

        // Iniciar la generación de asteroides
        InvokeRepeating("GenerarAsteroidesAleatorios", 0f, frecuenciaGeneracion);
    }


    //void GenerarAsteroide()
    //{
    //    // Generar asteroides en posiciones aleatorias en la parte superior de la pantalla
    //    float xPosition = Random.Range(-8f, 8f);
    //    Vector2 spawnPosition = new Vector2(xPosition, 6f);

    //    // Crear un nuevo asteroide
    //    GameObject asteroide = Instantiate(asteroidePrefab, spawnPosition, Quaternion.identity);

    //    // Aplicar velocidad al asteroide
    //    Rigidbody2D rb = asteroide.GetComponent<Rigidbody2D>();
    //    rb.velocity = Vector2.down * velocidadAsteroides;
    //}

    void GenerarAsteroidesAleatorios()
    {
        int cantidadAsteroides = Random.Range(cantidadMinima, cantidadMaxima + 1); // Generar un número aleatorio entre cantidadMinima y cantidadMaxima (incluyendo ambos extremos)

        for (int i = 0; i < cantidadAsteroides; i++)
        {
            // Generar asteroides en posiciones aleatorias en la parte superior de la pantalla
            float xPosition = Random.Range(-8f, 8f);
            Vector2 spawnPosition = new Vector2(xPosition, 6f);

            // Crear un nuevo asteroide
            GameObject asteroide = Instantiate(asteroidePrefab, spawnPosition, Quaternion.identity);

            // Aplicar velocidad al asteroide
            Rigidbody2D rb = asteroide.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.down * velocidadAsteroides;
        }
    }
}
