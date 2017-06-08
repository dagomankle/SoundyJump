using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reubicador : MonoBehaviour {

    public float ixPos= 0.0f;
    public float fxPos = 0.0f;

    void SetTransformX()
    {
        gameObject.transform.position = new Vector3(ixPos, transform.position.y, transform.position.z);
        print(transform.position.y);
    }

    // Update is called once per frame
    void Update () {
        if (transform.position.x <= fxPos)
        {
            SetTransformX();
        }
    }
}
