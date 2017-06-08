using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.SqliteClient;
using System.Data;
using System;

public class Conexion : MonoBehaviour 
{
	string conn="URI=file" + Application.dataPath + "/SoundyJumpDB.db";

	// Use this for initialization
	void Start () 
	{
		string conn = "URI=file:" + Application.dataPath + "/SoundyJumpDB.db"; //El path de la base
		IDbConnection dbconn;
		dbconn = (IDbConnection) new SqliteConnection(conn);
		dbconn.Open(); //Se abre la conexión con la base
		IDbCommand dbcmd = dbconn.CreateCommand();
		string sqlQuery = "SELECT scoresJugador, scoresValor " + "FROM Scores";
		dbcmd.CommandText = sqlQuery;
		IDataReader reader = dbcmd.ExecuteReader();
		while (reader.Read())
		{
			string scoresJugador = reader.GetString(1);
			int scoresValor = reader.GetInt32(2);

			Debug.Log( "Jugador= "+scoresJugador+"  Valor ="+scoresValor);
		}
		reader.Close();
		reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		dbconn.Close();
		dbconn = null;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
