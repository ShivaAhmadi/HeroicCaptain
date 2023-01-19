using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public bool isPaused=false;
    public AudioSource sound;

    void Start()
    {
        sound=GetComponent<AudioSource>();
        
    }

    void Update()
    {
        sound.volume=0;
        
    }

    public void PlaySound(){
        sound.volume=1;
        sound.Play();
        // if(isPaused){
        //      sound.UnPause();
        //      isPaused=false;
        // }
        // else{
        //     sound.Pause();
        //     isPaused=true;
        // }
    }
}
