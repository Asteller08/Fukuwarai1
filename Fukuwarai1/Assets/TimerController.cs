using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerController : MonoBehaviour
{
    public Text timerText;
    public Text CountText;
    [SerializeField] GameObject text;
    public float totalTime;
    int seconds;
    public float countdown;
    int count;
    float hintTime = -1.0f;
    int hintcount = 0;

    // Use this for initialization
    void Start()
    {
        CountText.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        timerText.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
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
        if (countdown <= 0)
        {
            if (totalTime >= 0)
            {
                text.SetActive(true);
                CountText.text = "";
                totalTime -= Time.deltaTime;
                seconds = (int)totalTime;
                timerText.text = seconds.ToString();

                if (hintcount <= 0 & Input.GetMouseButtonDown(1))
                {
                    hintcount++;
                    hintTime = 1.0f;
                }

                if (hintTime >= 0.0f)
                {
                    hintTime -= Time.deltaTime;
                    text.SetActive(false);
                }

            }
            if (totalTime < 0)
            {
                text.SetActive(false);
                timerText.text = "";
            }
        }

    }
}