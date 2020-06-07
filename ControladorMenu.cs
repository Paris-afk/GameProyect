using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
    }
    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
       
    }



    public void salirJuego()
    {
        Application.Quit();
    }
}
