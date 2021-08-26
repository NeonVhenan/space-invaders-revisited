using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{

    public string left;
    public string right;
    public int life = 3;

    public GameObject bullet;

    private float lastFired;

    // Use this for initialization
    void Start()
    {
        lastFired = 0;
    }

    // Update is called once per frame
    void Update()
    {

        GameObject tmpBullet;


        if (Input.GetKey(left) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-3f, 0f, 0f) * Time.deltaTime);
        }

        if (Input.GetKey(right) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(3f, 0f, 0f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
            if (Time.time > lastFired + 0.5)
            {
                tmpBullet = Instantiate(
                               bullet,
                               this.transform.position + this.transform.up / 2,
                                this.transform.rotation
                            );
                tmpBullet.GetComponent<AudioSource>().Play();
                lastFired = Time.time;
            }
    }
}
