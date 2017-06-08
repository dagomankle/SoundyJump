﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magoscript : MonoBehaviour {

    Animator anim;
    int saltoHash = Animator.StringToHash("Saltar");

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
            anim.SetTrigger(saltoHash);
        }
    }
}
