using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarNissanCivilian : MonoBehaviour {
    private GameObject AudiRs5; //Todos lOS carros 3D
    private GameObject VolksROC;
    public GameObject NissanCivilian; //El carro que queremos colocar
    // Use this for initialization
    public void Start () {
        //NissanCivilian = GameObject.Find("CivilianVehicle05");
    }
    //Con esta funcion quitamos cualquier carro activo y habilitamos el Civilian de Nissan
    public void quitarCarro()
    {
        //Quito todos los otros carros
        /*VolksROC = GameObject.Find("VolksRoc");
        VolksROC.SetActive(false);*/
        AudiRs5 = GameObject.Find("AudiRs5");
        AudiRs5.SetActive(false);
        //Habilito el carro deseado
        NissanCivilian.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
        //NissanCivilian = GameObject.Find("capi");
        //NissanCivilian.SetActive(true);
	}
}
