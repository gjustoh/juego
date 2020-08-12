using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
public class usuario : MonoBehaviour
{
    public void CrearUsuario(string user, string pass,string nombre, string email, Action<Respuesta> response){
        StartCoroutine( crearuser(user,pass,nombre,email,response));
    }
    private IEnumerator crearuser(string user, string pass,string nombre, string email, Action<Respuesta> response){
        secure form = new secure();
        form.secureformulario.AddField("nombre", nombre);
        form.secureformulario.AddField("user", user);
        form.secureformulario.AddField("password", pass);
        form.secureformulario.AddField("email", email);
        WWW w = new WWW("http://localhost/juegos/CreateUser.php",form.secureformulario);
        yield return w;
        Debug.Log(w.text);
        response(JsonUtility.FromJson<Respuesta>(w.text));
    }
    public void Login(string user, string pass, Action<Respuesta> response){
        StartCoroutine( LoginResp(user,pass,response));
    }
    private IEnumerator LoginResp(string user, string pass, Action<Respuesta> response){
        secure form = new secure();
        form.secureformulario.AddField("user", user);
        form.secureformulario.AddField("password", pass);
        WWW w = new WWW("http://localhost/juegos/Login.php",form.secureformulario);
        yield return w;
        Debug.Log(w.text);
        response(JsonUtility.FromJson<Respuesta>(w.text));
    }
}
[Serializable]
public class Respuesta{
    public bool hecho = false;
    public string mensaje = "";
    // public string nombre= "";
}
