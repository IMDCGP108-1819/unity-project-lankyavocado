using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{

    //WHERE THE ASTEROID MOVEMENT STARTS AND ENDS
    public Rigidbody2D Asteroid;
    private Vector2 mouseStartPosition;
    private Vector2 mouseEndPosition;
    public bool didClick;
    public bool didDrag;
    public bool canInteract;
    private float AsteroidVelocityX;
    private float AsteroidVelocityY;
    public float constantSpeed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///GIVES ME WORLD COORDINATES
		if (Input.GetMouseButttonDown(0))
            MouseClicked();
    }
        if (Input.GetMouseButton(0)) {

    }

    //IF THE PLAYER CLICKS THEIR MOUSE ANYWHERE ON THE SCREEN
    public void MouseClicked()
    {
        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mouseStartPosition);
        didClick = true;

    }
    //CREATES THE ANGLE THAT THE ARROWS POINTING
    public void MouseDragged(){
        didDrag = true;
        //MOVE THE ARROW
    }

}

        //NOW KNOWS WHERE THE PLAYER CLICKED/HAS CLICKED SOMEWHERE
   