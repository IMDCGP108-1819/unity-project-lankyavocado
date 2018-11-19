using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject Squiggle;
    public int numberOfSquigglesToStart;

	// Use this for initialization
	void Start () {
        int numberOfSquigglesCreate = 0;

		//CREATES SQUIGGLES ON THE SPAWN POINTS
        if(numberOfSquigglesCreate < numberOfSquigglesToStart) {
            for (int i = 0; i < spawnPoints.Length; i++) {
                int SquiggleToCreate = Random.Range(0, 2);
                if (SquiggleToCreate == 0) {
                    Instantiate(Squiggle, spawnPoints[i].position, Quaternion.identity);
                    //CHANGES THE NUMBER OF SQUIGGLES THAT SPAWN EACH TIME
                    
                    numberOfSquigglesCreate++;
                }
            }
        }
	}
    //PART 9 
	
	// Update is called once per frame
	void Update () {
		
	}
}
