using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour {
	public float fuerzaSalto = 100f;
	public bool enSuelo = true;	
	public Transform comprobadorSuelo;
	private float comprobadorRadio = 0.08f;
	public LayerMask mascaraSuelo;
	private bool dobleSalto = false;
	private bool corriendo = false;
	public float velocidad = 1f;
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate(){
		if (corriendo) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidad, GetComponent<Rigidbody2D> ().velocity.y);
		}

		//enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		//if (enSuelo) {
	//		dobleSalto = false;
	//	}
	}

	// Update is called once per frame
	void Update () {

		enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		if (enSuelo) {
			dobleSalto = false;
		}
		if (Input.GetMouseButtonDown (0)) {
			if (corriendo) {
				if (enSuelo || !dobleSalto) {
					GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, fuerzaSalto);	
					if(!dobleSalto && !enSuelo)
						dobleSalto = true;
				}
			} else {
				corriendo = true;
				NotificationCenter.DefaultCenter ().PostNotification (this, "PersonajeEmpiezaACorrer");
			}

		}

	}
}
