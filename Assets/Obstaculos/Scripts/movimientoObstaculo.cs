using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoObstaculo : MonoBehaviour {

    // Use this for initialization
   
    public float velocidad = 0.5f;  
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position = new Vector3(transform.position.x - velocidad,  transform.position.y, transform.position.z   );
	}
}
