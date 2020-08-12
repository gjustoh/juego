using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class login : MonoBehaviour
{
    [SerializeField] private Text mensaje = null;
    [Header("login")]
    [SerializeField] private InputField contralog =null;
    [SerializeField] private InputField userlog =null;
    [Header("registro")]
    [SerializeField] private GameObject loginUI =null;
    [SerializeField] private GameObject registroUI =null;
    [SerializeField] private InputField nombre = null;
    [SerializeField] private InputField user = null;
    [SerializeField] private InputField password = null;
    [SerializeField] private InputField passwordVal = null;
    [SerializeField] private InputField email = null;
    [Header("bienvenida")]
    [SerializeField] private Text nombreBienvenida = null;
    [SerializeField] private GameObject bienvenida =null;
    private usuario usuario =null;
    private bool verificacion=false;
    private void Awake() {
        usuario =GameObject.FindObjectOfType<usuario>();

    }
    public void CambiarEscena(){
        SceneManager.LoadScene("Menu");
    }
    public void ubmitLogin(){
        if(userlog.text==""|| contralog.text==""){
            mensaje.text ="Por favor llenar todos los campos";
            return;
        }
        else {
            mensaje.text ="Procesando...";
            usuario.Login(userlog.text, contralog.text, delegate(Respuesta response){
            mensaje.text = response.mensaje;
            nombreBienvenida.text = response.mensaje;
            verificacion = response.hecho;
            if (verificacion)
            {
                Bienvenida();
            }
        });    
        }
    }
    public void submitRegister(){
        if(user.text==""|| password.text==""|| nombre.text==""||email.text==""||passwordVal.text==""){
            mensaje.text ="Por favor llenar todos los campos";
            return;
        }
        else if(password.text ==passwordVal.text){
            mensaje.text ="Procesando...";
            usuario.CrearUsuario(user.text, password.text, nombre.text, email.text, delegate(Respuesta response){
            mensaje.text = response.mensaje;
        });    
        }
        else {
            mensaje.text = "Contraseñas diferentes";
        }
    }
    public void Login(){


        mensaje.text ="";
        contralog.text ="";
        userlog.text ="";
        nombre.text = "";
        user.text = "";
        password.text = "";
        passwordVal.text = "";
        email.text = "";
        nombreBienvenida.text = "";
        registroUI.SetActive(false);
        loginUI.SetActive(true);
        bienvenida.SetActive(false);
    }
    public void Registro(){
        
        mensaje.text ="";
        contralog.text ="";
        userlog.text ="";
        nombre.text = "";
        user.text = "";
        password.text = "";
        passwordVal.text = "";
        email.text = "";
        nombreBienvenida.text = "";
        registroUI.SetActive(true);
        loginUI.SetActive(false);
        bienvenida.SetActive(false);
    }
    public void Bienvenida(){
        mensaje.text ="";
        registroUI.SetActive(false);
        loginUI.SetActive(false);
        bienvenida.SetActive(true);
    }
    void Start() {
        mensaje.text ="";
        
        contralog.text ="";
        userlog.text ="";
        nombre.text = "";
        user.text = "";
        password.text = "";
        passwordVal.text = "";
        email.text = "";
        nombreBienvenida.text = "";
        registroUI.SetActive(false);
        bienvenida.SetActive(false);
        loginUI.SetActive(true);
    }
}
