using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterDead : MonoBehaviour
{

  
    // Start is called before the first frame update
    void Start()
    {
      
    }


    private void OnTriggerEnter(Collider playerCollider)
    {
        if (playerCollider.CompareTag("Player"))
        {
 
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            GameObject fpscontrol = GameObject.Find("FPSController");
            Destroy(fpscontrol);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Menu");
        }
    }


    // Update is called once per frame
    void Update()
    {
           
    }
}
