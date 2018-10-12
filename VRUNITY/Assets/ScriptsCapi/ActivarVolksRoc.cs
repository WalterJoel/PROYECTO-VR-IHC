using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVolksRoc : MonoBehaviour {
    private GameObject NissanCivilians; //Todos lOS carros 3D
    private GameObject AudiRs5; //Todos lOS carros 3D
    private GameObject ColorAudi;
    public GameObject VolksROC; //El carro que queremos colocar
                               // Use this for initialization
    void Start () {
		
	}

    //Con esta funcion quitamos cualquier carro activo y habilitamos el Civilian de Nissan
    public void quitarCarro()
    {

        //Solo si esta inactivo
        if (!VolksROC.active)
        {
            VolksROC.SetActive(true);
            AudiRs5 = GameObject.Find("AudiRs5");
            AudiRs5.SetActive(false);

        }

        //Desactivo colores del AUDI
        //ColorAudi = GameObject.Find("ColoresAudi");
        //ColorAudi.SetActive(false);
        //Habilito los colores
        /*GameObject ColorFerrari = GameObject.Find("ColoresFerrari");
        ColorFerrari.SetActive(true);*/
        //Habilito el carro deseado
        
    }

    // Update is called once per frame
    void Update()
    {
        //NissanCivilian = GameObject.Find("capi");
        //NissanCivilian.SetActive(true);
    }
}
