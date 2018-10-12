using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerScript : MonoBehaviour {

    // Use this for initialization
    //private UnityScript scriptActual;
    private GameObject scriptActual;
    private void Start()
    {
        
    }
    public void click() {
        //Obtengo el script
        scriptActual = GameObject.FindWithTag("Player");
        scriptActual.GetComponent<RotarEscenario>().enabled= false;
        //Detengo el script
        //scriptActual.enabled(=false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
