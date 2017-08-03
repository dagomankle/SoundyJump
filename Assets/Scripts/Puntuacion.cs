using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntuacion : MonoBehaviour {
	public int puntuacion;
	private bool corriendo = false;
	public Text score;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
		puntuacion = 0;
		score.text = puntuacion.ToString ();
	}

	void PersonajeEmpiezaACorrer(Notification notificacion){
		corriendo = true;
	}
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
//		if (corriendo) {
//			puntuacion++;
//			score.text = puntuacion.ToString ();
//		}

	}







}
