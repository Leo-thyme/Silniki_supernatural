using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject menu_panel;
    public GameObject options_panel;
    public GameObject exit_panel;

    public void ShowMenuPanel() 
    {
        menu_panel.SetActive(true);
        options_panel.SetActive(false);
        exit_panel.SetActive(false);
    }

    public void ShowOptionsPanel()
    {
        menu_panel.SetActive(false);
        options_panel.SetActive(true);
        exit_panel.SetActive(false);
    }

    public void ShowExitPanel()
    {
        menu_panel.SetActive(false);
        options_panel.SetActive(false);
        exit_panel.SetActive(true);
    }

    public void StartGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
