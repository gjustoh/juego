using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VHS;
using System;
namespace Name
{
public class puzzle : MonoBehaviour
{
    public  Text objeto;
    public  Text mensaje;
    InteractableBase inte =null;
    public Text puntaje;
    public string com;
    public GameObject prueba;
    public GameObject canvas ;
        // public static string 
    // Start is called before the first frame update

    public void validar(){
        
        inte = GameObject.FindGameObjectWithTag("objetos").GetComponent<InteractableBase>();
        if(objeto.text == prueba.name){
            puntaje.text =Convert.ToString(int.Parse(puntaje.text)+1);
            Destroy(prueba);
            canvas.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else{
            mensaje.text = "Intente otra vez";
        }
        inte = null;
        
    }
    public void retroceder(){
        Time.timeScale = 1;
        canvas.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
    }
    public void recibir(GameObject obj){
        prueba = obj;
        Debug.Log("recibido");
    }
}
    
}
