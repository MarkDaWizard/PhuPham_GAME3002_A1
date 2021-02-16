//Phu Pham
//101250748
//GAME3002 Assignment 1


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //Rotate camera with mouse
     float mouseX = (Input.mousePosition.x / Screen.width ) - 0.5f;
     float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
     transform.localRotation = Quaternion.Euler (new Vector4 (-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    
    }
}
