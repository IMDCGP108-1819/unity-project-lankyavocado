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
    public GameObject Arrow;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
        ///GIVES ME WORLD COORDINATES
		if (Input.GetMouseButtonDown(0) && canInteract) {
            MouseClicked();
        }
        if (Input.GetMouseButton(0) && canInteract) {
            MouseDragged();
        }
        if(Input.GetMouseButtonUp(0) && canInteract) {
            ReleaseMouse();
        }
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
        Arrow.SetActive(true);
        Vector2 tempMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float diffX = mouseStartPosition.x - tempMousePosition.x;
        float diffY = mouseStartPosition.y - tempMousePosition.y;
        //14:11 Part2
    }
    public void ReleaseMouse() {
        //ASTEROID MOVES AT SAME SPEED NO MATTER HOW HARD IT'S PULLED
        //NORMALIZING THE VECTOR
        mouseEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        AsteroidVelocityX = (mouseStartPosition.x - mouseEndPosition.x);
        AsteroidVelocityY = (mouseStartPosition.y - mouseEndPosition.y);
        Vector2 tempVelocity = new Vector2(AsteroidVelocityX, AsteroidVelocityY).normalized;
        Asteroid.velocity = constantSpeed * tempVelocity;
        didClick = false;
        didDrag = false;
        canInteract = false;
    }
    
}

        //NOW KNOWS WHERE THE PLAYER CLICKED/HAS CLICKED SOMEWHERE
   