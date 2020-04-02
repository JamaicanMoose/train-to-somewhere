﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    // Start is called before the first frame update

    public float bgSpeed;
    public Renderer bgRend;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(0f, bgSpeed * Time.deltaTime);
    }
}
