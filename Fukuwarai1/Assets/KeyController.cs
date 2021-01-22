using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRangex = 5.0f;
    public float moveableRangey = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -moveableRangex, moveableRangex), Mathf.Clamp(transform.position.y, -moveableRangey, moveableRangey));
    }
}
