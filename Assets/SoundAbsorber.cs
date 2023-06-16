using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAbsorber : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var characterPosition = GameObject.Find("Character").transform.position;

        if (Physics.Raycast(transform.position, characterPosition, Mathf.Infinity))
        {
            var carAudio = GetComponent<AudioSource>();
            carAudio.volume = 1.0f;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit");
        }
        else
        {
            var carAudio = GetComponent<AudioSource>(); 
            carAudio.volume = 0.5f;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("Did not Hit");
        }

    }
}
