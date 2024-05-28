using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextLevel()
    {
        var currenntSceneIndex = SceneManager.GetActiveScene().buildIndex;
        var newSceneIndex = currenntSceneIndex + 1;
        PlayerPrefs.SetInt("currentLevel", newSceneIndex);
        SceneManager.LoadScene(newSceneIndex);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NewGame()
    {
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadScene(1);
    }

    public void LoadCurrentLevel()
    {
        var currentLevel = PlayerPrefs.GetInt("currentLevel");
        SceneManager.LoadScene(currentLevel);
    }
}
