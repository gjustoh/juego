using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambiarEscenas : MonoBehaviour
{
    // public GameObject canvas;   
    private void Start() {
        // canvas.SetActive(false);
    }
    public void CambiarEscena(){
        SceneManager.LoadScene("SampleScene");
    }
    public void CambiarEscenaMenu(){
        SceneManager.LoadScene("Menu"); 
    }
    private void Update( )
    {
        if( Input.GetKeyDown( KeyCode.P ) )
            Debug.Log( "p key was pressed." );

        if( Input.GetKeyUp( KeyCode.Space ) )
            Debug.Log( "Space key was released." );
    }
}
