using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float ballSpeed = 0.04f;
    public Vector3 moveVector;

    public EventSystemCustom eventSystem;

    public float xDirection;
    public float yDirection;

    // Start is called before the first frame update
    void Start()
    {
        xDirection = RandomReturn();
        yDirection = RandomReturn();
        moveVector = new Vector3(ballSpeed * xDirection, ballSpeed * yDirection, 0);
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = new Vector3(ballSpeed * xDirection, ballSpeed * yDirection, 0);

        transform.position += moveVector;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            xDirection *= -1;
            yDirection *= 1;
            //if (xDirection > 0 && yDirection > 0)
            //{
            //    xDirection *= -1;
            //    yDirection *= 1;
            //}
            //else if (xDirection < 1 && yDirection > 0)
            //{
            //    xDirection *= -1;
            //    yDirection *= 1;
            //}
            //else if (xDirection < 0 && yDirection < 0)
            //{
            //    xDirection *= -1;
            //    yDirection *= 1;
            //}
            //else if (xDirection > 0 && yDirection < 0)
            //{
            //    xDirection *= -1;
            //    yDirection *= 1;
            //}
        }

        if (other.gameObject.CompareTag("UpDown"))
        {
            xDirection *= 1;
            yDirection *= -1;
            //if(xDirection > 0 && yDirection > 0)
            //{
            //    xDirection *= 1;
            //    yDirection *= -1;
            //}
            //else if(xDirection < 0 && yDirection > 0)
            //{
            //    xDirection *= -1;
            //    yDirection *= -1;
            //}
            //else if (xDirection < 0 && yDirection < 0)
            //{
            //    xDirection *= 1;
            //    yDirection *= -1;
            //}
            //else if (xDirection > 0 && yDirection < 0)
            //{
            //    xDirection *= 1;
            //    yDirection *= -1;
            //}

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("OpponentSide"))
        {
            eventSystem.OnScorePlayer.Invoke();
            eventSystem.OnDecreaseHeartOpponent.Invoke();
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("PlayerSide"))
        {
            eventSystem.OnScoreOpponent.Invoke();
            eventSystem.OnDecreaseHeartPlayer.Invoke();
            Destroy(this.gameObject);
        }
    }

    private float RandomReturn()
    {
        int value =  UnityEngine.Random.Range(0, 2);
        if (value == 0)
            return 1;
        return -1;
    }

}
