﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destroy on load: " + name);
    }
    
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip " + levelMusicChangeArray[level]);
        if(thisLevelMusic) //if music attached
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void SetVolume (float volume)
    {
        audioSource.volume = volume;
    }

}
