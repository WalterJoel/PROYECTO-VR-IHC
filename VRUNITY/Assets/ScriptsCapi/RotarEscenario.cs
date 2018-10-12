using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarEscenario : MonoBehaviour
{

    // Use this for initialization
    public bool control = false;
    float secondsCounter = 0;
    float secondsToCount = 7;
    void Start()
    {

    }

    public void activarControl()
    {
        control = true;
    }
    // Update is called once per frame
    public void desactivarControl()
    {
        control = true;
    }
    public void Update()
    {
        secondsCounter += Time.deltaTime;
        if (control == true) {
            transform.Rotate(new Vector3(0, 0.5f, 0));
        }
        /*if (secondsCounter >= secondsToCount)
        {
            secondsCounter = 0;
            control = false;
        }*/
    }
}
