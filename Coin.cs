using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    
     public static int coinsCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Moneda creada ");
        
        coinsCount++;
        ScoreText.scoreValue = 50;

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("has tocado la moneda");


        if (collider.CompareTag("Player")){
            Destroy(gameObject);
        }
    }


    private void OnDestroy()
    {
        
        coinsCount--;
        ScoreText.scoreValue --;
        if (coinsCount == 0)
        {

            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            Debug.Log("EL juego ha terminado ");

            GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Firework");
            foreach(GameObject firework in fireworks)
            {
                firework.GetComponent<ParticleSystem>().Play();
            }
            GameObject fpscontrol = GameObject.Find("FPSController");
            Destroy(fpscontrol);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("MenuWin");

        }
    }
}
