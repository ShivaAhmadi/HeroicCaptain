using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_Player : MonoBehaviour
{
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
        
    }

    void Update()
    {
        
    }
}
