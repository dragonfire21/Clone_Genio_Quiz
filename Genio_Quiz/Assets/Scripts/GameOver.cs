using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameOver : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
