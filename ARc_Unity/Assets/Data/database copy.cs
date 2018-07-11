using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 
using System.Data; 
using System;

public class database : MonoBehaviour {

	// Use this for initialization
	void Start () {
	string conn = "URI=file:" + Application.dataPath + "/test"; //Path to database.
     IDbConnection dbconn;
     dbconn = (IDbConnection) new SqliteConnection(conn);
     dbconn.Open(); //Open connection to the database.
     IDbCommand dbcmd = dbconn.CreateCommand();
     string sqlQuery = "SELECT LAST_NAME, FIRST_NAME, POSITION " + "FROM EMPLOYEE";
     dbcmd.CommandText = sqlQuery;
     IDataReader reader = dbcmd.ExecuteReader();
     while (reader.Read())
     {
         string in_name = reader.GetString(0)+reader.GetString(1);
         string pos = reader.GetString(2);
        
         Debug.Log("  name ="+in_name+"  position ="+  pos);
     }
     reader.Close();
     reader = null;
     dbcmd.Dispose();
     dbcmd = null;
     dbconn.Close();
     dbconn = null;
 }
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
//}
