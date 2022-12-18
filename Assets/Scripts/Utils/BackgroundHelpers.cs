using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundHelpers : MonoBehaviour
{
    public Renderer backgroundrenderer;
    void Start()
    {
        
    }

    void Update()
    {
        if (backgroundrenderer != null){
            backgroundrenderer.material.mainTextureOffset = new Vector2(0f, 0.07f * Time.time);
        }
    }
}
