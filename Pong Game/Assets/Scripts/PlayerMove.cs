using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 0.06f;
    public int playerLife = 3;
    public int playerScore = 0;

    public OpponentMove opponentPlayer;

    public Vector3 moveVector;

    public EventSystemCustom eventSystem;


    // Start is called before the first frame update
    void Start()
    {
        moveVector = new Vector3(0, playerSpeed * 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLife > 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += moveVector;

                OpponentMove(moveVector, true);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= moveVector;

                OpponentMove(moveVector, false);
            }
        }
        else
        {
            // Invoke you lost
            eventSystem.YouLost.Invoke();
        }
    }

    public void OpponentMove(Vector3 vector, bool up)
    {
        opponentPlayer.Move(vector, up);
    }
}
