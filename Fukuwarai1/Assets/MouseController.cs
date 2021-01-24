using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
    public TimerController timeController;
    public Text NameText;
    public string name;

    float playT;
    float startT;

    float sumTime1 = 0.0f;
    float sumTime2 = 0.0f;
    float judge = 0.0f;
    float judge2 = 0.0f;

    Vector3 screenPoint;
    Vector3 offset;

    Rigidbody2D rb;

    void Start()
    {  
        rb = this.GetComponent<Rigidbody2D>();
        NameText.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        playT = timeController.PlayTime;
        startT = timeController.StartTime;
    }

    void Update()
    {
        
        if (judge >= 0)
        {
            sumTime1 += Time.deltaTime;
            judge = startT - sumTime1;

        }
        else
        {
            if (judge2 >= 0)
            {
                sumTime2 += Time.deltaTime;
                judge2 = playT - sumTime2;
                NameText.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                if (Input.GetMouseButtonDown(0))
                {
                    this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
                    this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
                }

            }
            else
            {
                NameText.text = "";
            }
            
        }
    }

    void OnMouseDrag()
    {
        if (judge <= 0 & judge2 >= 0)
        {
            Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
            transform.position = currentPosition;
            NameText.text = name.ToString();
        }

    }
}
