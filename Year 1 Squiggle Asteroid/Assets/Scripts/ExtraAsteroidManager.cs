using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraAsteroidManager : MonoBehaviour {

    //REFERENCE TO MAIN ASTEROID CONTROLLER
    private AsteroidController asteroidController;
    private GameManager gameManager;
    //AMOUNT OF TIME BETWEEN THE WHEN THE ASTEROIDS LAUNCH
    public float asteroidWaitTime;
    private float asteroidWaitTimeSeconds;
    public int numberOfExtraAsteroids;
    public int numberOfAsteroidsToFire;
    public ObjectPool objectPool;
    public Text numberOfAsteroidsText;

	// Use this for initialization
	void Start () {
        asteroidController = FindObjectOfType<AsteroidController>();
        gameManager = FindObjectOfType<GameManager>();
        asteroidWaitTimeSeconds = asteroidWaitTime;
        numberOfExtraAsteroids = 0;
        numberOfAsteroidsToFire = 0;
        numberOfAsteroidsText.text = "" + 1;
        
	}
	
	// Update is called once per frame
	void Update () {
        numberOfAsteroidsText.text = "" + (numberOfExtraAsteroids + 1);
        if(asteroidController.currentAsteroidState == AsteroidController.AsteroidState.fire){
            if(numberOfAsteroidsToFire > 0) {
                asteroidWaitTimeSeconds -= Time.deltaTime;
                if(asteroidWaitTimeSeconds <= 0) {
                    GameObject Asteroid = objectPool.GetPooledObject("Extra Asteroid");
                    if (Asteroid != null) {
                        Asteroid.transform.position = AsteroidController.AsteroidLaunchPosition;
                        Asteroid.SetActive(true);
                        gameManager.AsteroidsInScene.Add(Asteroid);
                        Asteroid.GetComponent<Rigidbody2D>().velocity = AsteroidController.temp.Velocity;
                        asteroidWaitTimeSeconds = asteroidWaitTime;
                        numberOfAsteroidsToFire--;   
                    }
                    asteroidWaitTimeSeconds = asteroidWaitTime;
                    //PART 13 25:38
                }
            }
        }
	}
}
