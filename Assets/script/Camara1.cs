using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    public void CutToShot () {
        Camera.main.transform.localPosition = transform.position;
        Camera.main.transform.localRotation = transform.rotation;
    }
}