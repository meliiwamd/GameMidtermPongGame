using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text scorePlayer;
    public Text scoreOpponent;
    public Text heartPlayer;
    public Text heartOpponent;
    public Text result;

    public PlayerMove player;
    public OpponentMove opponent;

    public BallPlacer start;

    public EventSystemCustom eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        eventSystem.OnScorePlayer.AddListener(OnScorePlayer);
        eventSystem.OnScoreOpponent.AddListener(OnScoreOpponent);
        eventSystem.OnDecreaseHeartPlayer.AddListener(OnDecreaseHeartPlayer);
        eventSystem.OnDecreaseHeartOpponent.AddListener(OnDecreaseHeartOpponent);
        eventSystem.YouLost.AddListener(YouLost);
        eventSystem.YouWin.AddListener(YouWin);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnDecreaseHeartPlayer()
    {
        start.start = true;
        player.playerLife -= 1;
        heartPlayer.text = player.playerLife.ToString();
    }

    public void OnDecreaseHeartOpponent()
    {
        start.start = true;
        opponent.opponentLife -= 1;
        heartOpponent.text = opponent.opponentLife.ToString();
    }

    public void OnScorePlayer()
    {
        player.playerScore += 1;
        scorePlayer.text = player.playerScore.ToString();
    }

    public void OnScoreOpponent()
    {
        opponent.opponentScore += 1;
        scoreOpponent.text = opponent.opponentScore.ToString();
    }

    public void YouLost()
    {
        string text = "YOU LOST!";
        result.text = text.ToString();
    }

    public void YouWin()
    {
        string text = "YOU WON!";
        result.text = text.ToString();
    }
}
