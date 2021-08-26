using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour {

    private GameStateManager gsm;
    private Text finalTime;

	// Use this for initialization
	void Start () {
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
        finalTime = GetComponent<Text>();
        finalTime.text = "" + gsm.lastUpdate;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
