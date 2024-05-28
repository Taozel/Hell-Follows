using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("TestPlayerScene");
    }
    public void QuitMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
