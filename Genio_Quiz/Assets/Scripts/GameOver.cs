using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameOver : MonoBehaviour
{
    private void Update() => ExitGame();

    void ExitGame() //leaves the game
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ReturnMenu() //back to the menu
    {
        SceneManager.LoadScene(0);
    }
}
