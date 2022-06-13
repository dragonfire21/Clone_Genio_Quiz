using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas; //gets the Canvas menu
    [SerializeField] private GameObject instruCanvas; //takes the Canvas instruction

    private void Update() => ExitGame();

    void ExitGame() //leaves the game
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void StartGame() //when you click the start button the game begins
    {
        SceneManager.LoadScene(1);
    }

    public void Instru() //shows the instructions 
    {
        menuCanvas.SetActive(false);
        instruCanvas.SetActive(true);
    }

    public void Return() //gets out of the instructions 
    {
        menuCanvas.SetActive(true);
        instruCanvas.SetActive(false);
    }

}
