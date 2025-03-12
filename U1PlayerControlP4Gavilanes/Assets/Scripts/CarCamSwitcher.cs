using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamSwitcher : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;
    
    // Start is called before the first frame update
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //allow switching state of the cameras on key press
        if(Input.GetButtonDown("Down"))
        {
            Cam1.enabled = !Cam1.enabled;
            Cam2.enabled = !Cam2.enabled;
        }
    }
}
