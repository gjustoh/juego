using System.Collections.Generic;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using UnityEngine;


public class mysql_script : MonoBehaviour {
    void Start() {
        Mysql();  
    }
    public void Mysql(){
        MySqlConnection conexion = new MySqlConnection();
        string query ="Server= localhost;Database=juegos;Uid=root;Pwd=root1;CharSet=utf8;";
        conexion.ConnectionString = query;
        try
        {
            conexion.Open();
            Debug.Log("Coneccion exitosa");
        }
        catch (MySqlException e)
        {
            Debug.Log("error de conexion: "+ e);
            throw;
        }
    }
}