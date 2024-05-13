using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance; // Статическая ссылка на себя для доступа из других скриптов
    private bool isPaused = false; // Флаг, указывающий на то, находится ли игра на паузе

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        // Time.timeScale = 1f;
        ModelScore.score = 5;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ComebackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public bool IsPaused()
    {
        return isPaused;
    }
}