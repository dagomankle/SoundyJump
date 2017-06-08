using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reubicador : MonoBehaviour {

    public float ixPos= 0.0f;
    public float fxPos = 0.0f;
    public bool pausa = false;


    //Funcion para setear la posicion de un objeto 
    void SetTransformX()
    {
        gameObject.transform.position = new Vector3(ixPos, transform.position.y, transform.position.z); //Crea el vector de posicion x, y
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyUp("escape"))  //Para que el juego se pause con la tecla esc
        {
            PausaChange(); //Se llama al metodo correspondiente
        }

        //Revisa donde esta el objeto y decide si se debe poner al inicio nuevamente, ademas solo se llama a la funcion cuando no esta pausado
        if (transform.position.x <= fxPos && pausa == false)
        {
            SetTransformX();
        }
    }

    //Cambia el valor de la variable en funcion de lo necesario
    void PausaChange()
    {
        if (pausa == false)
            pausa = true;
        else
            pausa = false;
    }
}
