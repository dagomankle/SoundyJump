using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
public class GameOverScript : MonoBehaviour {
	public GUIStyle myGUIStyle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI()
	{
	int valor = MaxScore ();
	GUI.Label(new Rect (550, 380, 400, 40), "High Score: "+ valor, myGUIStyle);
    int valorActual = LastScore ();
	GUI.Label(new Rect (370, 112, 400, 40), " "+ valorActual, myGUIStyle);
	}
	int MaxScore()
	{
		int maxScore = 0;
		string conn = "URI=file:" + Application.dataPath + "/SJDBase/SoundyJumpBd2.db"; //Path to database.
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection(conn);
		dbconn.Open(); //Open connection to the database.
		IDbCommand dbcmd = dbconn.CreateCommand();
		string sqlQuery = "Select max(score) from scores; ";

		dbcmd.CommandText = sqlQuery;

		IDataReader reader = dbcmd.ExecuteReader();
		while (reader.Read())
		{
			maxScore = reader.GetInt32(0);
		}
		reader.Close();
		reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		dbconn.Close();
		dbconn = null;

		return maxScore;
	}
 
	int LastScore()
	{
		int lastScore = 0;
		string conn = "URI=file:" + Application.dataPath + "/SJDBase/SoundyJumpBd2.db"; //Path to database.
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection(conn);
		dbconn.Open(); //Open connection to the database.
		IDbCommand dbcmd = dbconn.CreateCommand();
		string sqlQuery = "SELECT * FROM scores ORDER BY nombre DESC limit 1;";

		dbcmd.CommandText = sqlQuery;

		IDataReader reader = dbcmd.ExecuteReader();
		while (reader.Read())
		{
			lastScore= reader.GetInt32(1);
		}
		reader.Close();
		reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		dbconn.Close();
		dbconn = null;

		return lastScore;
	}
}
