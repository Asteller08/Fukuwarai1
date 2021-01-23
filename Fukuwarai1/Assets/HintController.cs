using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintController : MonoBehaviour
{
    float hintcount = -1.0f;
    [SerializeField] GameObject text;
    // Update is called once per frame
    void Update()
    {
        text.SetActive(false);

        if (Input.GetMouseButtonDown(1))
        {
            hintcount = 0.5f;
        }
        if (hintcount >= 0.0f)
        {
            text.SetActive(true);
            hintcount -= Time.deltaTime;
        }

    }
}