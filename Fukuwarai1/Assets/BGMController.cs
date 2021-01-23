using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioClip sound2;
    AudioSource audioSource;
    public float totalTime;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        totalTime -= Time.deltaTime;
        if (totalTime <= 0 & count < 1)
        {
            audioSource.PlayOneShot(sound2);
            count++;
        }
    }
}
