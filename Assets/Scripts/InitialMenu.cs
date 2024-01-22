using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialMenu : MonoBehaviour
{
    //llamar escena para jugar
   public void Jugar(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    public void Salir(){
        Debug.Log("Exit...");
        Application.Quit();
    }
}
