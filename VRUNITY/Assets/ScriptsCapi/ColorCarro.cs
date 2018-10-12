
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCarro : MonoBehaviour
{

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //render blue color
    public void AmarilloColor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }

    //render red color
    public void AzulColor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    //render greencolor
    public void CelesteColor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }


    //render yellow color
    public void MoradoColor()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }
    //render yellow color
    public void RojoColor()
    {
        renderer.material = BodyColorMat[4];
        CurrMat = renderer.material;
    }
}