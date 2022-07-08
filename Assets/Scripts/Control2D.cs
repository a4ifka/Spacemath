using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control2D : MonoBehaviour
{
   




    void Update()
    {   

        if(Input.GetKey("a")) {
            transform.position = new Vector2(-2, transform.position.y);
            
        }

        if(Input.GetKey("d")) {
             transform.position = new Vector2(2, transform.position.y);
            
        }

        if(Input.GetKey("s")) {
            transform.position = new Vector2(0, transform.position.y);
        }
             
        

           
        

           
          
        
    }
}
