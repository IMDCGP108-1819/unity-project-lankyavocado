using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject Squiggle;
    public int numberOfSquigglesToStart;
    public int level;
    public List<GameObject> squigglesInScene;


	// Use this for initialization
	void Start () {
        level = 1;
        int numberOfSquigglesCreate = 0;

		//CREATES SQUIGGLES ON THE SPAWN POINTS
        if(numberOfSquigglesCreate < numberOfSquigglesToStart) {
            for (int i = 0; i < spawnPoints.Length; i++) {
                int SquiggleToCreate = Random.Range(0, 3);
                if (SquiggleToCreate == 0) {
                    squigglesInScene.Add(Instantiate(Squiggle, spawnPoints[i].position, Quaternion.identity));
                    //CHANGES THE NUMBER OF SQUIGGLES THAT SPAWN EACH TIME
                    
                    numberOfSquigglesCreate++;
                }
            }
        }
	}
   
	
	// Update is called once per frame
	void Update () {
		
	}
}
