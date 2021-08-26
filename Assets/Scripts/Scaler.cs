using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gob = collision.gameObject;

        if (gob.tag == "Alien")
        {
            gob.GetComponent<MoveAlien>().StarScale();
        }


    }

}
