using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;

public class Destructor : MonoBehaviour {
	public Text score ;
	public int puntuacion;
	private bool corriendo = false;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
		puntuacion = 0;
		score.text = puntuacion.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PersonajeEmpiezaACorrer(Notification notificacion){
		corriendo = true;
	}

	void FixedUpdate(){
		if (corriendo) {
			puntuacion++;
			score.text = puntuacion.ToString ();
		}

	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {

			Debug.Log (puntuacion);
			Ingreso (puntuacion, System.DateTime.Now.ToString());

			Application.LoadLevel("MenuGameOver");
			//fin del juego
			//se guarda el score en la base
		}
		else
		Destroy (other.gameObject);
	}

	void Ingreso(int score, string nombre)
	{
		string conn = "URI=file:" + Application.dataPath + "/SJDBase/SoundyJumpBd2.db"; //Path to database.
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection(conn);
		dbconn.Open(); //Open connection to the database.
		IDbCommand dbcmd = dbconn.CreateCommand();
		//string sqlQuery = "SELECT value,name, randomSequence " + "FROM PlaceSequence";

		string sqlInsert = "INSERT INTO scores(nombre, score) VALUES ('" + nombre + "', '" + score.ToString() + "');";
		//dbcmd.CommandText = sqlQuery;

		dbcmd.CommandText = sqlInsert;
		dbcmd.ExecuteNonQuery();
//		IDataReader reader = dbcmd.ExecuteReader();
//        while (reader.Read())
//        {
//            //int value = reader.GetInt32(0);
//            //string name = reader.GetString(1);
//            //int rand = reader.GetInt32(2);
//
//            //Debug.Log("value= " + value + "  name =" + name + "  random =" + rand);
//        }
//        reader.Close();
//        reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		dbconn.Close();
		dbconn = null;
	}
}
