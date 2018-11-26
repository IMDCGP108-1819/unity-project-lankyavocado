using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SquiggleHealthManager : MonoBehaviour {

    public int SquiggleHealth;
    private Text SquiggleHealthText;
    private GameManager gameManager;

	//SET BRICK HEALTH TO WHATEVER THE GAME LEVEL IS
	void Start () {
        gameManager = FindObjectOfType<GameManager>();
        SquiggleHealth = gameManager.level;
        SquiggleHealthText = GetComponentInChildren<Text>();
       
	}
	
	// Update is called once per frame
	void Update () {
        SquiggleHealthText.text = "" + SquiggleHealth;
        if(SquiggleHealth<= 0) {
            //DESTROY SQUIGGLES WHEN THEYVE BEEN HIT
            this.gameObject.SetActive(false);
        }
	}
    //METHOD TO REDUCE THE HEALTH OF THE SQUIGGLES
    void TakeDamage(int damageToTake){
        SquiggleHealth -= damageToTake;
    }
    void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.tag == "Asteroid"){
            TakeDamage(1);
        }
        
    }
}
