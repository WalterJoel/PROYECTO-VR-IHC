using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAudiRs5 : MonoBehaviour {

    //private GameObject NissanCivilians; //Todos lOS carros 3D
    //private GameObject ferrari;
    public GameObject AudiRs5; //El carro que queremos colocar
                               // Use this for initialization
    private GameObject ferrari;
    public void Start()
    {
        //NissanCivilian = GameObject.Find("CivilianVehicle05");
    }
    //Con esta funcion quitamos cualquier carro activo y habilitamos el Civilian de Nissan
    public void quitarCarro()
    {
        if (!AudiRs5.active)
        {
            //Quito todos los otros carros
            ferrari = GameObject.Find("Ferrari3D");
            ferrari.SetActive(false);
            //Activo Colores Audi
            /*GameObject ColorAudi = GameObject.Find("ColoresAudi");
            ColorAudi.SetActive(true);*/
            /*NissanCivilians = GameObject.Find("NissanCivilian");
            NissanCivilians.SetActive(false);*/
            //Habilito el carro deseado
            AudiRs5.SetActive(true);

        }

    }

    // Update is called once per frame
    void Update()
    {
        //NissanCivilian = GameObject.Find("capi");
        //NissanCivilian.SetActive(true);
    }
}
