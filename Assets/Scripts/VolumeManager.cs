﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour
{

    public VolumeController[] vcObjects;

    public float maxVolumeLevel = 1.0f;
    public float currentVolumeLevel;

    // Start is called before the first frame update
    void Start()
    {
        vcObjects = FindObjectsOfType<VolumeController>();

        if(currentVolumeLevel > maxVolumeLevel)
        {
            currentVolumeLevel = maxVolumeLevel;
        }
        
        for(int i = 0; i < vcObjects.Length; i++)
        {
            vcObjects[i].setAudioLevel(currentVolumeLevel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
