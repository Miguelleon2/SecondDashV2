using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
public void Reiniciar()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    Time.timeScale = 1f;
}


public void MenuInicial(string nombre)
{
    SceneManager.LoadScene(nombre);
    Time.timeScale = 1f;
}


}
