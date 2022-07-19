using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        ChangeState(GameState.GenerateGrid);
        Debug.Log('s');
    }
    public void ChangeState(GameState newState)
    {
     

        switch (newState)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnPlayers:
                UnitManager.Instance.SpawnPlayer();
                break;
            case GameState.SpawnEnemies:

                break;
            case GameState.PlayerTurn:
                break;
            case GameState.EnemyTurn:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }

    
}
public enum GameState
{
    GenerateGrid = 0,
    SpawnPlayers = 1,
    SpawnEnemies = 2,
    PlayerTurn = 3,
    EnemyTurn = 4
}






