using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlien : MonoBehaviour
{

    public float hDis;
    public float vDis;
    public float speed;
    public float direction;

    private Vector3 target;
    private Vector3 startPos;
    private Vector3 originalScale;
    private Transform moveTrans;
    private GameStateManager gsm;
    private bool isScaling;
    private float lastScale;

    // Use this for initialization
    void Start()
    {
        moveTrans = transform;
        isScaling = false;
        originalScale = transform.localScale;
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, 3));

        if (isScaling && Time.time > lastScale + 0.100f)
        {
            transform.localScale = transform.localScale * 0.9f;
            lastScale = Time.time;

            if (transform.localScale.y <= originalScale.y * 0.5f)
            {
                Destroy(this.gameObject);
                gsm.NbAliens--;
            }
        }
    }

    public void StarScale()
    {
        isScaling = true;
    }
}