using System;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    [SerializeField] private Screen _initialScreen;
    [SerializeField] private Screen[] _screens;
    private Screen _currentScreen;

    private void Awake()
    {
        foreach (var screen in _screens)
        {
            screen.DisableScreen();
        }

        if(_initialScreen != null)
            ShowScreen(_initialScreen);
    }

    public void CloseCurrentScreen() => _currentScreen?.DisableScreen();
    public void ShowMainScreen() => ShowScreen(FindScreenWithType(typeof(MainScreen)));

    private void ShowScreen(Screen screen)
    {
        CloseCurrentScreen();
        screen?.EnableScreen();
        _currentScreen = screen;
    }

    private Screen FindScreenWithType(Type type)
    {
        foreach (var screen in _screens)
        {
            if (screen.GetComponent(type) != null)
            {
                return screen;
            }
        }
        return null;
    }
}