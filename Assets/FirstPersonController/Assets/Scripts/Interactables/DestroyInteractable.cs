using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Name;
namespace VHS
{    
    public class DestroyInteractable : InteractableBase
    {
        public GameObject canvas;
        public puzzle referencia;
        bool activo;
        public override void OnInteract()
        {
            canvas.SetActive(true);
            base.OnInteract();
            referencia =  GameObject.FindGameObjectWithTag("puzzle").GetComponent<puzzle>();
            Cursor.lockState = CursorLockMode.None;
            referencia.recibir(base.objeto());
            Cursor.visible = true;
            Time.timeScale = 0;          
        }
    }
}
