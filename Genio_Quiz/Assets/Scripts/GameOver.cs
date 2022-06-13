using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameOver : MonoBehaviour
{
    public void ReturnMenu() //back to the menu
    {
        SceneManager.LoadScene(0);
    }
}
