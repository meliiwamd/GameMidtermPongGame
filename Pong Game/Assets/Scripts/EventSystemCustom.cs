using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSystemCustom : MonoBehaviour
{
    public UnityEvent OnScorePlayer;
    public UnityEvent OnScoreOpponent;
    public UnityEvent OnDecreaseHeartPlayer;
    public UnityEvent OnDecreaseHeartOpponent;
    public UnityEvent YouLost;
    public UnityEvent YouWin;

    void Awake()
    {
        OnScorePlayer = new UnityEvent();
        OnScoreOpponent = new UnityEvent();
        OnDecreaseHeartPlayer = new UnityEvent();
        OnDecreaseHeartOpponent = new UnityEvent();
        YouLost = new UnityEvent();
        YouWin = new UnityEvent();
    }

}
