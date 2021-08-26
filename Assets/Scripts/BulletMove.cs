using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    private Rigidbody2D myRigid;
    GameStateManager gsm;

    // Use this for initialization
    void Start()
    {

        myRigid = this.GetComponent<Rigidbody2D>();

        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();

    }

    // Update is called once per frame
    void Update()
    {

        myRigid.AddForce(this.transform.up * 25);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(this.gameObject);
    }
}