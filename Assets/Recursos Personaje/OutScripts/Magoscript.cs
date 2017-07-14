using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magoscript : MonoBehaviour {

    Animator anim;
    int saltoHash = Animator.StringToHash("Saltar");
    public float velocidad;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp("space"))
        {
            anim.SetTrigger(saltoHash);// moviemento fisico cambiar tiempo de animacion ????
            while(true)
                transform.position = new Vector3(transform.position.x - velocidad, transform.position.y, transform.position.z);

        }
    }
}
