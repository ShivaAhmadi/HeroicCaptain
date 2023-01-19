using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Manager : MonoBehaviour
{
    public GameObject SoundCntrolButton;
    public Sprite audioOffSprite;
    public Sprite audioOnSprite;

    // Start is called before the first frame update
    void Start()
    {
        if(AudioListener.pause==true){
            SoundCntrolButton.GetComponent<Image>().sprite=audioOffSprite;
        }
        else {
            SoundCntrolButton.GetComponent<Image>().sprite=audioOnSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundCntrol(){
        if(AudioListener.pause==true){
            AudioListener.pause=false;
            SoundCntrolButton.GetComponent<Image>().sprite=audioOnSprite;
        }
        else{
             AudioListener.pause=true;
            SoundCntrolButton.GetComponent<Image>().sprite=audioOffSprite;
        }
    }
}
