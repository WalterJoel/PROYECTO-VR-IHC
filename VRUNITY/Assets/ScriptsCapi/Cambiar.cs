using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiar : MonoBehaviour {
    
    void Start()
    {  //Cuando empezamos 
        //GetComponent<Renderer>().material = noLooky;
    }
    public void verAudi()
    {
        Application.LoadLevel("AudiInside"); //Ir a la escena que queremos 	

    }
    public void retornarMenu()
    {
        Application.LoadLevel("StartScene"); //Ir a la escena que queremos 	
    }
    public void verNissan()
    {
        Application.LoadLevel("NissanInside"); //Ir a la escena que queremos
    }
    public void verFerrari()
    {
        Application.LoadLevel("FerrariInside"); //Ir a la escena que queremos
    }
}
