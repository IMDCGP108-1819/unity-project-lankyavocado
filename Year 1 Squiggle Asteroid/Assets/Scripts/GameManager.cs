using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject Squiggle;

	// Use this for initialization
	void Start () {
		//CREATES SQUIGGLES ON THE SPAWN POINTS
        for(int i = 0; i < spawnPoints.Length; i++) {
            Instantiate(Squiggle, spawnPoints[i].position, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
