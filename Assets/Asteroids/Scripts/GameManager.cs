using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] string gameSceneName;
    // Az egész scene-t újratöltjük!
    public void RestartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
