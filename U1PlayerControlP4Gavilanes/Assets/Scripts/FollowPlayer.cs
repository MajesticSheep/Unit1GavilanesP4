using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //public Camera mainCamera;
    //public Camera hoodCamera;
    //public KeyCode switchKey;
    
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to the player;s position
        transform.position = player.transform.position + offset;
    }
}
