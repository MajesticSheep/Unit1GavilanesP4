using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarCameraTwo : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
 
    public GameObject player;                                
    private Vector3 offset = new Vector3(0, 1.8f, 1.4f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Axis setup
        

        transform.position = player.transform.position + offset;
        
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }

    
}
