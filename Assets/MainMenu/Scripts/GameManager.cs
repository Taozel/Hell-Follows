using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private Material skybox;

    public float x = 1;
    private void Start()
    {

        //if (skybox != null) SetSkyBox();
    }
    void Update()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Dungeon");
    }
    public void QuitMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    

    private void SetSkyBox()
    {
        //RenderSettings.skybox = skybox;
        //DynamicGI.UpdateEnvironment();
    }
}
