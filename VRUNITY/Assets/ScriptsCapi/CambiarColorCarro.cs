﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CambiarColorCarro : MonoBehaviour {

    // Update is called once per frame

    void Update () {
		
	}
    public void Start()
    {
        //Fetch the Renderer from the GameObject
        /*Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.gray);*/

        //Find the Specular shader and change its Color to red
        /*rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);*/
    }
    public void colorAzul()
    {
        Renderer rend = GetComponent<Renderer>();
        //Find the Specular shader and change its Color to red
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
    }
    public void colorAzSul()
    {
        Renderer rend = GetComponent<Renderer>();
        //Find the Specular shader and change its Color to red
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.green);
    }
}

