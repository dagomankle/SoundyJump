using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reubicador : MonoBehaviour {

    public float ixPos= 0.0f;
    public float fxPos = 0.0f;
    public bool pausa = false;


    void SetTransformX()
    {
        gameObject.transform.position = new Vector3(ixPos, transform.position.y, transform.position.z);
        print(transform.position.y);
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyUp("escape"))
        {
            PausaChange();
        }

        if (transform.position.x <= fxPos && pausa == false)
        {
            SetTransformX();
        }
    }

    void PausaChange()
    {
        if (pausa == false)
            pausa = true;
        else
            pausa = false;
    }
}
