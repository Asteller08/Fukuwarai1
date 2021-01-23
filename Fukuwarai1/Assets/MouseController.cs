using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{

    public Text NameText;
    public string name;
    float countdown = 6.0f;
    int count;

    Vector3 screenPoint;
    Vector3 offset;

    Rigidbody2D rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
        }
        if (countdown <= 0) {
            if (Input.GetMouseButtonDown(0)) {
                this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
                this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            }
        }
    }

    void OnMouseDrag()
    {
        if (countdown <= 0)
        {
            Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
            transform.position = currentPosition;
            NameText.text = name.ToString();
        }

    }
}
