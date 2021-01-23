using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MidleGround : MonoBehaviour
{
    [SerializeField] GameObject text;
    public float totalTime;
    int seconds;
    public float countdown;
    int count;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;

        }
        if (countdown < 0)
        {
            if (totalTime >= 0)
            {
                totalTime -= Time.deltaTime;
                text.SetActive(true);
            }
            if (totalTime < 0)
            {
                text.SetActive(false);
            }
        }

    }
}
