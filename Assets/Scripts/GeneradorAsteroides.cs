using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class GeneradorAsteroides : MonoBehaviour
//{
//    public GameObject asteroidePrefab;
//    public float velocidadAsteroides = 0f;
//    public float tiempoEntreSets = 15f;
//    public int cantidadMinima = 0;
//    public int cantidadMaxima = 0;

//    void Start()
//    {
//        // Iniciar la generación de asteroides
//        Invoke("GenerarAsteroidesAleatorios", 0f);
//    }

//    void GenerarAsteroidesAleatorios()
//    {
//        int cantidadAsteroides = Random.Range(cantidadMinima, cantidadMaxima + 1); // Generar un número aleatorio entre cantidadMinima y cantidadMaxima (incluyendo ambos extremos)

//        for (int i = 0; i < cantidadAsteroides; i++)
//        {
//            // Generar asteroides en posiciones aleatorias en la parte superior de la pantalla
//            float xPosition = Random.Range(-8f, 8f);
//            Vector2 spawnPosition = new Vector2(xPosition, 6f);

//            // Crear un nuevo asteroide
//            GameObject asteroide = Instantiate(asteroidePrefab, spawnPosition, Quaternion.identity);

//            // Aplicar velocidad al asteroide
//            Rigidbody2D rb = asteroide.GetComponent<Rigidbody2D>();
//            rb.velocity = Vector2.down * velocidadAsteroides;
//        }

//        // Programar la siguiente generación de asteroides después de un tiempo
//        Invoke("GenerarAsteroidesAleatorios", tiempoEntreSets);
//    }
//}


public class GeneradorAsteroides : MonoBehaviour
{
    public GameObject asteroidePrefab;
    public float velocidadAsteroides = 2f;
    public float tiempoEntreSets = 15f;
    public int cantidadMinima = 1;
    public int cantidadMaxima = 3;

    private bool generacionActiva = true;

    void Start()
    {
        // Iniciar la generación de asteroides
        GenerarAsteroidesAleatorios();
    }

    void GenerarAsteroidesAleatorios()
    {
        if (generacionActiva)
        {
            int cantidadAsteroides = Random.Range(cantidadMinima, cantidadMaxima + 1);

            for (int i = 0; i < cantidadAsteroides; i++)
            {
                float xPosition = Random.Range(-8f, 8f);
                Vector2 spawnPosition = new Vector2(xPosition, 6f);

                GameObject asteroide = Instantiate(asteroidePrefab, spawnPosition, Quaternion.identity);

                Rigidbody2D rb = asteroide.GetComponent<Rigidbody2D>();
                rb.velocity = Vector2.down * velocidadAsteroides;
            }

            // Desactivar la generación temporalmente
            generacionActiva = false;

            // Programar la siguiente generación de asteroides después de un tiempo
            Invoke("ActivarGeneracion", tiempoEntreSets);
        }
    }

    void ActivarGeneracion()
    {
        generacionActiva = true;
    }
}
