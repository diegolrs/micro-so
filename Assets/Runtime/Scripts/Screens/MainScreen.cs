using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreen : Screen
{
    [SerializeField] GameMode _gameMode;

    public void QuitGame()
    {
        _gameMode.QuitGame();
    }
}