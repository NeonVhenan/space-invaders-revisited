using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    public int scoreValue;
    private GameStateManager gsm;

    public GameObject alienExplosion;
    public GameObject playerExplosion;
    GameObject gsmObject;

    // Use this for initialization
    void Start()
    {

        gsmObject = GameObject.FindWithTag("GameStateManager");

        if (gsmObject != null) {
            gsm = gsmObject.GetComponent<GameStateManager>();
        }

        if (gsm == null) {
            Debug.Log("Cannot find 'GameStateManager' script");
        }
    }

    void OnTriggerEnter(Collider other) {

        if (other.tag == "Boundary") {
            return;
        }

        Instantiate(alienExplosion, transform.position, transform.rotation);

        if (other.tag == "Player") {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

       /* gsm.AddScore(scoreValue);
        Destroy(other.gsmObject);
        Destroy(gsmObject); */
    }

    // Update is called once per frame
    void Update()
    {

    }
}
