using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseController : MonoBehaviour {

    public static bool GamePaused = false;
    public GameObject PauseMenuUi;

    private Controls _menucontrols;
	
	// Update is called once per frame

    void Awake()
    {
         _menucontrols = new Controls();
    }

    private void OnEnable()
    {
        _menucontrols.Player.Pausar.performed += Pause;
        _menucontrols.Player.Pausar.Enable();

        _menucontrols.Player.Resume.performed += Resume;
        _menucontrols.Player.Resume.Enable();

        _menucontrols.Player.Menu.performed += LoadMenu;
        _menucontrols.Player.Menu.Enable();

        _menucontrols.Player.Quit.performed += QuitGame;
        _menucontrols.Player.Quit.Enable();

        _menucontrols.Player.Restart.performed += RestartGame;
        _menucontrols.Player.Restart.Enable();
    }

    private void OnDisable()
    {
        _menucontrols.Player.Pausar.performed -= Pause;
        _menucontrols.Player.Pausar.Disable();

        _menucontrols.Player.Resume.performed -= Resume;
        _menucontrols.Player.Resume.Disable();

        _menucontrols.Player.Menu.performed -= LoadMenu;
        _menucontrols.Player.Menu.Disable();

        _menucontrols.Player.Quit.performed -= QuitGame;
        _menucontrols.Player.Quit.Disable();

        _menucontrols.Player.Restart.performed -= RestartGame;
        _menucontrols.Player.Restart.Disable();
    }

    public void Resume(InputAction.CallbackContext context)
    {
        if(GamePaused){
            PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        }
        
    }

    void Pause(InputAction.CallbackContext context)
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;  
    }

    public void QuitGame(InputAction.CallbackContext context)
    {
         if(GamePaused)
         {
            Time.timeScale = 1f;
            Application.Quit();
            Debug.Log("Quitting Game...");
         }
        
    }

    public void LoadMenu(InputAction.CallbackContext context)
    {
        if(GamePaused){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu principal");
        Debug.Log("Loading Menu...");
        GamePaused = false;
        }

    }

    public void RestartGame(InputAction.CallbackContext context)
    {
         if(GamePaused)
         {
            Time.timeScale = 1f;
            SceneManager.LoadScene("GameScene");
            Debug.Log("Restarting Game...");
            GamePaused = false;
         }
        
    }

    public void MuteGame()
    {
        Debug.Log("Mutting Game...");
    }
}
