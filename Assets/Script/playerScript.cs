using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerScript : MonoBehaviour {

    public GameObject Scoretext;
    private int score = 0;
    public GameObject finish;
    private float finishposY = -10.0f;

    [Range (0f, 30f)] public float speed = 10;
    private void FixedUpdate()
    {
        Scoretext = GameObject.Find("scoretext");
        finish = GameObject.Find("goaltext");

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
        if (this.transform.position.y < this.finishposY)
        {
            finish.GetComponent<Text>().text = "GAME OVER";
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cubetag") {
            score += 10;
            Debug.Log(score);
            Scoretext.GetComponent<Text>().text = score + "pt";
        }
    }
}
