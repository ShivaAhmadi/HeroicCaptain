using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public bool isPaused=false;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseSound(){
        if(isPaused){
             sound.UnPause();
             isPaused=false;
        }
        else{
            sound.Pause();
            isPaused=true;
        }
    }
}
