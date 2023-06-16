using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAbsorber : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var characterPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        if (!Physics.Linecast(transform.position, characterPosition))
        {
            var carAudio = GetComponent<AudioSource>();
            carAudio.volume = 1.0f;
            Debug.DrawLine(transform.position, characterPosition, Color.red);
            Debug.Log("Did Hit");
        }
        else
        {
            var carAudio = GetComponent<AudioSource>();
            carAudio.volume = 0.5f;
            Debug.DrawLine(transform.position, characterPosition, Color.red);
            Debug.Log("Did not Hit");
        }

    }
}
