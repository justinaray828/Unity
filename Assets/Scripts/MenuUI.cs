using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Attach script to Parent UI Canvas and child a menu to access. The script contains useful methods
/// for the menu to access and use.
/// </summary>
public class MenuUI : MonoBehaviour
{ 
    private string cancelInput = "Cancel"; //Unity input manager axis

    [Header("Add Child Menu to toggle")]
    [SerializeField] private GameObject menu;
    [Header("Main menu scene index if one exist in game")]
    [SerializeField] private int MainMenuSceneIndex = 0;

    private bool menuToggleBool = false;
    private bool cancelKeyPressed = false;

    void Update()
    {
        if( CancelKeyIsPressed() )
        {
            menu.SetActive(menuToggleBool);
            menuToggleBool = !menuToggleBool;
        }
    }

    private bool CancelKeyIsPressed()
    {
        if( Input.GetAxis(cancelInput) > 0 && !cancelKeyPressed)
        {
            cancelKeyPressed = true;
            return true;
        }

        if (Input.GetAxis(cancelInput) == 0)
        {
            cancelKeyPressed = false;
        }

        return false;
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void GoToScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(MainMenuSceneIndex);
    }
}
