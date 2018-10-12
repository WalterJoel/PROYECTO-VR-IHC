using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorNissan : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		
	}
    //public Material noLooky;
    public Material eyeSpy;

    // Use this for initialization
    void Start()
    {  //Cuando empezamos 
       //GetComponent<Renderer>().material = noLooky;
    }

    public void verEsteColor() //Cuando el puntero apunta
    {
        GetComponent<Renderer>().material = eyeSpy;
    }
}

