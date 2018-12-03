using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other){
        if(other.gameObject.tag == "Asteroid"){
            //DO SOMETHING
            //DISABLES ITSELF IN THE SCENE
            this.gameObject.SetActive(false);
        }
    }

}
