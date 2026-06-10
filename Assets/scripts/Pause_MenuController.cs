using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_MenuController : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject MainPanel;
    public GameObject ExitValidation;
    public GameObject OptionsPanel;

    public void Resume()
    {

    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ShowMainPanel()
    {
        MainPanel.SetActive(true);
        ExitValidation.SetActive(false);
        OptionsPanel.SetActive(false);
    }

    public void ShowExitValidation()
    {
        MainPanel.SetActive(false);
        ExitValidation.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    public void ShowOptionsPanel()
    {
        MainPanel.SetActive(false);
        ExitValidation.SetActive(false);
        OptionsPanel.SetActive(true);
    }

    public void OpenPauseMenu()
    {
        PauseMenu.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ClosePauseMenu()
    {
        PauseMenu.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void Update()
    {

    }
}
