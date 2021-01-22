using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public Text CountText;
    public float totalTime;
    int seconds;
    public float countdown;
    int count;
    

    // Use this for initialization
    void Start()
    {
        Color color = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();
        }
        if (countdown < 0)
        {
            if (totalTime >= 0)
            {
                Color color = gameObject.GetComponent<Renderer>().material.color;
                color.a = 1.0f;
                gameObject.GetComponent<Renderer>().material.color = color;
                CountText.text = "";
                totalTime -= Time.deltaTime;
                seconds = (int)totalTime;
                timerText.text = seconds.ToString();
            }
            if (totalTime < 0)
            {
                Color color = gameObject.GetComponent<Renderer>().material.color;
                color.a = 0.0f;
                gameObject.GetComponent<Renderer>().material.color = color;
            }
        }

    }
}