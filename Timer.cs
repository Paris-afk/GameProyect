using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 120.0f;
  //  Text timeRemaining;
    private float countDown = 0.0f;
    void Start()
    {
        countDown = maxTime;
        TimeText.timeValue = maxTime;
      //  timeRemaining = GetComponent<Text>();
    }
    
    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        TimeText.timeValue -= Time.deltaTime;
        //  timeRemaining.text = countDown.ToString();
        if (countDown <= 0)
        {   
            //aqui es para reiniciar el nivel por si se le acaba el tiempo
            Coin.coinsCount = 0;
            ScoreText.scoreValue = 50;
            // Application.LoadLevel(Application.loadedLevel);
            //SceneManager.LoadScene(0);
            //SceneManager.LoadScene("Menu");
            GameObject fpscontrol = GameObject.Find("FPSController");
            Destroy(fpscontrol);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("MenuLosser");

        }
    }
}
