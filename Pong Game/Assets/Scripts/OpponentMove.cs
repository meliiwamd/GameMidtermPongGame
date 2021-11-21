using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMove : MonoBehaviour
{
    public int opponentLife = 3;
    public int opponentScore = 0;

    public EventSystemCustom eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(opponentLife == 0)
        {
            // Invoke you win
            eventSystem.YouWin.Invoke();
        }
    }

    public void Move(Vector3 vector, bool up)
    {
        if (up)
            transform.position += vector * -1;
        else
            transform.position -= vector * -1;
    }
}
