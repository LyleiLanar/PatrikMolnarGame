using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] string gameSceneName;
    // Az eg�sz scene-t �jrat�ltj�k!
    public void RestartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
