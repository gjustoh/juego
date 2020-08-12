using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logica : MonoBehaviour
{
    
    public Text puntaje;
    Timer tiempo = null;
    [SerializeField] private GameObject puzzle =null;
    [SerializeField] private GameObject canvas =null;
    [SerializeField] private GameObject win =null;
    [SerializeField] private GameObject lose =null;
private void Start() {
    tiempo = GameObject.FindGameObjectWithTag("Player").GetComponent<Timer>();
}
    public string puntajet;
    // Update is called once per frame
    void Update()
    {
        if( tiempo.Tiempo <=0){
            puzzle.SetActive(false);
           canvas.SetActive(false);
           canvas.SetActive(true);
           lose.SetActive(true);
           win.SetActive(false);
           Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
       if (int.Parse(puntaje.text)==42)
       {
           puzzle.SetActive(false);
           canvas.SetActive(false);
           canvas.SetActive(true);
           lose.SetActive(false);
           win.SetActive(true);
           Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
       }
       puntajet = puntaje.text;
       if( Input.GetKeyDown( KeyCode.F1 ) )
            Menu();
    }
    public void Menu(){
        puzzle.SetActive(false);
        canvas.SetActive(false);
        canvas.SetActive(false);
        lose.SetActive(false);
        win.SetActive(false);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
