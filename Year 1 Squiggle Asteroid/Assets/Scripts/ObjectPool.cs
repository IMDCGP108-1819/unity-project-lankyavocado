using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HOW MANY WE WANT ON HAND, HOW MANYS ON HAND
[System.Serializable]
public class ObjectPoolItem{
    public int amountToPool;
    public GameObject objectToPool;
    }

public class ObjectPool : MonoBehaviour {
    //OBJECTS AFTER WE CREATE THEM
    public List<GameObject> pooledObjects;
    public List<ObjectPoolItem> itemsToPool;
    
	// Use this for initialization
	void Start () {
        //FOREACHLOOP ONLY DOES CERTAIN COMMANDS IF THE OBJECT NEEDS CERTAIN CRITERIA
        pooledObjects = new List<GameObject>();
        foreach(ObjectPoolItem item in itemsToPool){
            for (int i = 0; i < item.amountToPool; i++) {
                GameObject obj = (GameObject)Instantiate(item.objectToPool);
                obj.SetActive(false);
                pooledObjects.Add(obj);
               

            }
        }
       

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //ALLOWS ME TO BRING BACK A GAME OBJECT FROM THE POOL
    public GameObject GetPooledObject(string tag){
        for(int i = 0; i < pooledObjects.Count; i++){
            if(pooledObjects [i].activeInHierarchy == false && pooledObjects [i].tag == tag){
                return pooledObjects[i];
            }
        }
        return null;
    }
  

}
