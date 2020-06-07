using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    // Start is called before the first frame update
    public static float timeValue;
    Text timeText;
    void Start()
    {
        timeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "" + timeValue;
    }
}
