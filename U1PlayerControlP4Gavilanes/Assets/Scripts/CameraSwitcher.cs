using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
  //public Camera InsideCar;
    
    public void showIt(GameObject gameObject)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.SetActive(true);
        }

        
    }


    public void hideIt(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    
    
        
       //f (Input.GetKey(KeyCode.Space))
      //{
          //gameObject.SetActive(false);
      //}
        
      //else if (Input.GetKey(KeyCode.Escape))
      //{
          //gameObject.SetActive(true);
      //}
    
}
