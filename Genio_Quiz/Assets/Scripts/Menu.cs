using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject instruCanvas;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instru()
    {
        menuCanvas.SetActive(false);
        instruCanvas.SetActive(true);
    }

    public void Return()
    {
        menuCanvas.SetActive(true);
        instruCanvas.SetActive(false);
    }

}
