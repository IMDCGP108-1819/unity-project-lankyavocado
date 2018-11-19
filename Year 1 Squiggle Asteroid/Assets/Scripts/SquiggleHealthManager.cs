using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SquiggleHealthManager : MonoBehaviour {

    public int SquiggleHealth;
    private Text SquiggleHealthText;

	// Use this for initialization
	void Start () {
        SquiggleHealthText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        SquiggleHealthText.text = "" + SquiggleHealth;
        if(SquiggleHealth<= 0) {
            //DESTROY SQUIGGLE
        }
	}
    //METHOD TO REDUCE THE HEALTH OF THE SQUIGGLES
    void TakeDamage(int damageToTake){
        SquiggleHealth -= damageToTake;
    }

}
