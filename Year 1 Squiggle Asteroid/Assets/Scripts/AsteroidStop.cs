using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidStop : MonoBehaviour
{

    //REFERENCE TO RIGIDBODY
    public Rigidbody2D Asteroid;
    public AsteroidController AsteroidControl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Asteroid") {
            //STOP THE ASTEROID
            Asteroid.velocity = Vector2.zero;
            //RESET THE LEVEL
            //SET THE ASTEROID AS ACTIVE
            AsteroidControl.currentAsteroidState = AsteroidController.AsteroidState.aim;
            //WAITS UNTIL ALL THE BALLS HAVE LANDED BEFORE IT CAN FIRE AGAIN

            //PART 11

        }
    }
}