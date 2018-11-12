using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public enum AsteroidState
    {
        aim,
        fire,
        wait,
        endShot
    }

    public AsteroidState currentAsteroidState;

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
        currentAsteroidState = AsteroidState.aim;
    }

    // Update is called once per frame
    void Update() {
        switch (currentAsteroidState) {
            case AsteroidState.aim:
                if (Input.GetMouseButtonDown(0)) {
                    MouseClicked();
                }
                if (Input.GetMouseButton(0)) {
                    MouseDragged();
                }
                if (Input.GetMouseButtonUp(0)) {
                    ReleaseMouse();
                }
                break;
            case AsteroidState.fire:

                break;
            case AsteroidState.wait:

                break;
            case AsteroidState.endShot:

                break;
            default:
                break;


        }


        ///GIVES ME WORLD COORDINATES
		
    }
     

    //IF THE PLAYER CLICKS THEIR MOUSE ANYWHERE ON THE SCREEN
    public void MouseClicked()
    {
        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mouseStartPosition);
     

    }
    //CREATES THE ANGLE THAT THE ARROWS POINTING
    public void MouseDragged(){
        //MOVE THE ARROW
        Arrow.SetActive(true);
        Vector2 tempMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //REPRESENT THE TWO SIDES OF THE TRIANGLE WHEN MOUSE IS DRAGGED
        float diffX = mouseStartPosition.x - tempMousePosition.x;
        float diffY = mouseStartPosition.y - tempMousePosition.y;
        if(diffY <= 0) {
            diffX = .01f;
        }
        float theta = Mathf.Rad2Deg*Mathf.Atan(diffX / diffY);
        Arrow.transform.rotation = Quaternion.Euler(0f, 0f, -theta); 
        //MIGHT NEED TO COME BACK HERE IF IT DOESNT WORK 
    }
    public void ReleaseMouse() {
        //ASTEROID MOVES AT SAME SPEED NO MATTER HOW HARD IT'S PULLED
        //NORMALIZING THE VECTOR
        //WHEN MOUSE IS RELASED ARROW GOES AWAY
        Arrow.SetActive(false);
        mouseEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        AsteroidVelocityX = (mouseStartPosition.x - mouseEndPosition.x);
        AsteroidVelocityY = (mouseStartPosition.y - mouseEndPosition.y);
        Vector2 tempVelocity = new Vector2(AsteroidVelocityX, AsteroidVelocityY).normalized;
        Asteroid.velocity = constantSpeed * tempVelocity;
        if(Asteroid.velocity == Vector2.zero) {
            return;
        }
        currentAsteroidState = AsteroidState.fire;
    }
    
}

        //NOW KNOWS WHERE THE PLAYER CLICKED/HAS CLICKED SOMEWHERE
   