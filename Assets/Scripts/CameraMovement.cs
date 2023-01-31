using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraRoot;
    public Transform pelaaja;
    void Start()
    {
        
    }

    // Update is called once per frame
    void  Update()
    {
        //kamera seuraa pelaajan positionia
        cameraRoot.position = Vector3.Lerp(cameraRoot.position, pelaaja.position, 0.005f); //oli 0.05f
        transform.LookAt(pelaaja);

    }
}
