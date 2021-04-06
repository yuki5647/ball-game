using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {
    private GameObject Scoretext;
    private int score = 0;

	// Use this for initialization
	void Start () {
        Scoretext = GameObject.Find("scoretext");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "balltag")
        {
            score += 100;
            
            Destroy(this.gameObject);
        }
    }
}
