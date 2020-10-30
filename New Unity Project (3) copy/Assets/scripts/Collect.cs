using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collect : MonoBehaviour


{
    
    public GameObject reward;
    


   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("collected");
        
        Instantiate(reward, transform.position, transform.rotation);
        
        Destroy(gameObject);

     
    }

   
}