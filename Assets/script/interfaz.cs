using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class interfaz : MonoBehaviour
{
    public Button boton;
    void Start(){
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void jugando(){
         boton.gameObject.SetActive(false);
        // m_Object.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}
