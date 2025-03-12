using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera backCamera;
    public KeyCode switchKey;
    
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1.8f, -1.18f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            backCamera.enabled = !backCamera.enabled;
        }
    }
}
