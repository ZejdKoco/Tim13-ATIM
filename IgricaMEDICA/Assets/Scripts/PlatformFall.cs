using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour {

    public float fallDelay = 2f;
    private Rigidbody2D rb2D;
	// Use this for initialization
	void Awake () {
        rb2D = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Invoke("Fall", fallDelay);
    }
    void Fall()
    {
        rb2D.isKinematic = false;
    }
}
