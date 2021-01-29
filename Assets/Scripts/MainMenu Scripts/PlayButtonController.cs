using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class PlayButtonController : MonoBehaviour
{
    private Controls _menucontrols;

    void Awake()
    {
        _menucontrols = new Controls();

    }

    private void OnEnable()
    {
        _menucontrols.Menu.Start.performed += HandleStart;
        _menucontrols.Menu.Start.Enable();
    }

    private void OnDisable()
    {
        _menucontrols.Menu.Start.performed -= HandleStart;
        _menucontrols.Menu.Start.Disable();
    }
    public void cambiarAJuego()
    {
        SceneManager.LoadScene("GameScene");

    }

    private void HandleStart(InputAction.CallbackContext context)
    {
        cambiarAJuego();
    }
}
