using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Clear rock when they hit the floor
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rock")
        { 
            Destroy(other.gameObject);
        }
        
    }
   
}
