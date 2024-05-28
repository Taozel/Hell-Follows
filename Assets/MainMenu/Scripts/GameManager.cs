using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private Material skybox;

    private void Start()
    {
        //if (skybox != null) SetSkyBox();
    }

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

    private void SetSkyBox()
    {
        //RenderSettings.skybox = skybox;
        //DynamicGI.UpdateEnvironment();
    }
}
