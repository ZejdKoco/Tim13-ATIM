using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScena : MonoBehaviour {
    public GameObject mainPanel;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    public void ponovi()
    {
        Application.LoadLevel("aa");
    }
    public void exit()
    {
        Application.Quit();
    }
}
