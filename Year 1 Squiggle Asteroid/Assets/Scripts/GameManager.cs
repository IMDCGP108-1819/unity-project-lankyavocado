using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject Squiggle;
    public GameObject extraAsteroidPowerup;
    public int numberOfSquigglesToStart;
    public int level;
    public List<GameObject> squigglesInScene;
    public List<GameObject> AsteroidsInScene;
    private ObjectPool objectPool;
    public int numberOfExtraAsteroidsInRow = 0;

    // Use this for initialization
    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
        level = 1;
        int numberOfSquigglesCreate = 0;

        //CREATES SQUIGGLES ON THE SPAWN POINTS
        if (numberOfSquigglesCreate < numberOfSquigglesToStart)
        {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                int SquiggleToCreate = Random.Range(0, 4);
                if (SquiggleToCreate == 0)
                {
                    squigglesInScene.Add(Instantiate(Squiggle, spawnPoints[i].position, Quaternion.identity));
                    //CHANGES THE NUMBER OF SQUIGGLES THAT SPAWN EACH TIME

                    numberOfSquigglesCreate++;
                
                } else if (SquiggleToCreate == 2 && numberOfExtraAsteroidsInRow == 0){
                    squigglesInScene.Add(Instantiate(extraAsteroidPowerup, spawnPoints[i].position, Quaternion.identity));
                    numberOfExtraAsteroidsInRow++;
                } 
            }
            numberOfExtraAsteroidsInRow = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //RESETS LEVEL AND PLACES SQUIGGLES
    }
    public void PlaceSquiggles() {
        level++;
        foreach(Transform position in spawnPoints)
        {
            int SquiggleToCreate = Random.Range(0, 3);
            if (SquiggleToCreate == 2 && numberOfExtraAsteroidsInRow == 0) {
                GameObject Squiggle = objectPool.GetPooledObject("Squiggle");
                squigglesInScene.Add(Squiggle);
                if (Squiggle != null)
                    Squiggle.transform.position = position.position;
                Squiggle.transform.rotation = Quaternion.identity;
                Squiggle.SetActive(true);
               
            }
            numberOfExtraAsteroidsInRow++;
        }
        numberOfExtraAsteroidsInRow = 0;
    }

}


