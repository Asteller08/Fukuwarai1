using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MidleGround : MonoBehaviour
{
    [SerializeField] GameObject text;
    public TimerController timeController;

    float playT;
    float startT;

    float sumTime = 0.0f;
    float sumTime2 = 0.0f;
    float judge = 0.0f;
    float judge2 = 0.0f;


    // Use this for initialization
    void Start()
    {
        playT = timeController.PlayTime;
        startT = timeController.StartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (judge >= 0)
        {
            sumTime += Time.deltaTime;
            judge = startT - sumTime;

        }
        else
        {
            judge = -100;
            if (judge2 >= 0)
            {
                sumTime2 += Time.deltaTime;
                judge2 = playT - sumTime2;
                text.SetActive(true);
            }
            else
            {
                text.SetActive(false);
            }
        }

    }
}
