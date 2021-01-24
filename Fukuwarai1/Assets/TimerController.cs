using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerController : MonoBehaviour
{
    public Text playText;
    public Text startText;
    [SerializeField] GameObject text;
    private float playTime = 11.0f;
    public float PlayTime
    {
        get { return this.playTime; }
        set { playTime = value; }
    }
     int seconds;

    private float startTime = 6.0f;
    public float StartTime
    {
        get { return this.startTime; }
        set { startTime = value; }
    }
    int start;
    float hintTime = -1.0f;
    int hintcount = 0;

    // Use this for initialization
    void Start()
    {
        startText.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        playText.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime >= 0)
        {
            startTime -= Time.deltaTime;
            start = (int)startTime;
            startText.text = start.ToString();
        }
        if (startTime <= 0)
        {
            if (playTime >= 0)
            {
                text.SetActive(true);
                startText.text = "";
                playTime -= Time.deltaTime;
                seconds = (int)playTime;
                playText.text = seconds.ToString();

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
            if (playTime < 0)
            {
                text.SetActive(false);
                playText.text = "";
            }
        }

    }
}