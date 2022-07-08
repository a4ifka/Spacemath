using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class ScriptForObject : MonoBehaviour
{
    
    public float speed;
    public float posY = 1.5f;
    public double waitTime;


    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    transform.Translate(Vector2.down * speed * Time.deltaTime);

    

 
    

    
   }

   IEnumerator waiter()
    {

        yield return new WaitForSeconds(2);
        speed = 0;
        yield return new WaitForSeconds(3);
        speed = 4;


    }        
    

    


}