using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    [SerializeField] private GameObject mostrar ;
    public void Login(){
        mostrar.SetActive(true);
    }
}
