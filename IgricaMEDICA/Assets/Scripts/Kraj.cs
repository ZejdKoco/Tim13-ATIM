using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraj : MonoBehaviour {
    private 

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel("menuScena");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game over");
            Application.Quit();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Application.Quit();
        }
    }
}
