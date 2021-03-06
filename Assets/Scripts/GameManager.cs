using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Start,
    Pause,
    End

}

public class GameManager : MonoBehaviour
{
    private LevelManager _levelManager;
    public GameState currentGameState;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = GetComponent<LevelManager>();
        currentGameState = GameState.Pause;
    }

    public void StartGame()
    {
        currentGameState=GameState.Start;
        _levelManager.StartLevel();

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           StartGame();
        }
    }
}
