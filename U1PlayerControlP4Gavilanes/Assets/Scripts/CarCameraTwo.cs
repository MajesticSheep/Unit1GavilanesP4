using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCameraTwo : MonoBehaviour
{

    public Gameobject player;
    private Vector3 offset = new Vector3(0, 1.8, 1.4);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transfrom.position + offset;
    }
}
