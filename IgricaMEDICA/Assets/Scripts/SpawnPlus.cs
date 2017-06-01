using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlus : MonoBehaviour {

    public Transform[] plusSpawns;
    public GameObject plus;
	// Use this for initialization
	void Start () {
        Spawn();
		
	}
	void Spawn()
    {
        for(int i = 0; i < plusSpawns.Length; i++)
        {
            int plusFlip = Random.Range(0, 2);
            if (plusFlip > 0)
                Instantiate(plus, plusSpawns[i].position, Quaternion.identity);
        }
    }
}
