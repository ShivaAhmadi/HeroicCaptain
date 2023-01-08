using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River_Movement : MonoBehaviour
{
    public Renderer meshRenderer;
    public float rivSpeed=0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(0, rivSpeed * Time.deltaTime);        
    }
}
