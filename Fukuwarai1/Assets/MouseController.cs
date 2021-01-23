using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{

    public Text NameText;
    public string name;
    public float totalTime;
    public float countdown;

    Vector3 screenPoint;
    Vector3 offset;

    Rigidbody2D rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        NameText.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
    }

    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
        }
        else
        {
            if (totalTime >= 0)
            {
                totalTime -= Time.deltaTime;
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
        if (countdown <= 0 & totalTime >= 0)
        {
            Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
            transform.position = currentPosition;
            NameText.text = name.ToString();
        }

    }
}
