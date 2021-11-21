using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlacer : MonoBehaviour
{
    public GameObject ball;
    public PlayerMove player;
    public OpponentMove opponent;

    public bool start = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (start && player.playerLife > 0 && opponent.opponentLife > 0)
        {
            start = false;
            GameObject run;
            run = Instantiate(ball);
            run.transform.position = new Vector3(transform.position.x, UnityEngine.Random.Range(-4, 4), transform.position.z);
        }
    }
}
