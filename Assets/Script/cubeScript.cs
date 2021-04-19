using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cubeScript : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.tag == "balltag")
        {
           

            Destroy(this.gameObject);
        }
    }
}
