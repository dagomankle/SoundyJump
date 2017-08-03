using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 1f;
	public float tiempoMax = 4f;
	// Use this for initialization
	void Start () {
		
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");  	
	}

	void PersonajeEmpiezaACorrer(Notification notificacion){
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Generar(){
		Instantiate (obj [Random.Range (0, obj.Length)], new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
	}
}
