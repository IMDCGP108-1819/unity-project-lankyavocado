using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquiggleMovementController : MonoBehaviour {
    public enum squiggleState {
        stop,
        move
    }
    //REFERENCE TO THE ENUM
    public squiggleState currentState;
    private bool hasMoved;

	// Use this for initialization
	void Start () {
        //WHEN THE SQUIGGLES FIRST ENTER THEY SHOULD STOP
        hasMoved = false;
        currentState = SquiggleMovementController.squiggleState.stop;
		
	}
	
	// Update is called once per frame
	void Update () {
        //MAKES THE SQUIGGLES MOVE DOWN ONE EACH LEVEL
        if(currentState == SquiggleMovementController.squiggleState.stop){
            hasMoved = false;
        }
        if (currentState == SquiggleMovementController.squiggleState.move){
            if (hasMoved == false) {
                transform.position = new Vector2(transform.position.x, transform.position.y - 1);
                currentState = SquiggleMovementController.squiggleState.stop;
                hasMoved = true;
            }
        }

	}
}
