using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
    [Range (0f, 30f)] public float speed = 10;
    private void FixedUpdate()
    {
        float moveHorizontel = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontel, 0.0f, moveVertical);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * speed);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
