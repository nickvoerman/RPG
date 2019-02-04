﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{

    private AudioSource theAudio;

    private float audioLevel;
    public float defaultaudio;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setAudioLevel(float volume)
    {
        if(theAudio == null)
        {
            theAudio = GetComponent<AudioSource>();
        }
        audioLevel = defaultaudio * volume;
        theAudio.volume = audioLevel;
    }

}
