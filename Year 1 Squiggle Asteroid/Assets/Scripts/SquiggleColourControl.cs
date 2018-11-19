using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquiggleColourControl : MonoBehaviour {

    //ADDED NEW SINCE IT WASNT WORKING
    public Gradient gradient;
    private new SpriteRenderer renderer;

	// Use this for initialization
    //THE COLOURS THAT THE SQUIGGLES CHANGE
    // HAD TO CHANGED COLOUR TO COLOR SINCE IT DIDN'T WORK 
	void Start () {
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = gradient.Evaluate (Random.Range(0f, 1f));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
