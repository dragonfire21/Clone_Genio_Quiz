using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class GameController : MonoBehaviour
{
    [Header("Arrays")]
    [SerializeField] private string[] quiz; //stores questions
    [SerializeField] private string[] answer; //stores the response that will appear on the button

    [Header("Btn1")]
    [SerializeField] private Text Btn1; //text that appears on the button1

    [Header("Btn2")]
    [SerializeField] private Text Btn2; //text that appears on the button2

    [Header("Btn3")]
    [SerializeField] private Text Btn3; //text that appears on the button3

    [Header("Btn4")]
    [SerializeField] private Text Btn4; //text that appears on the button4

    [Header("Questions")]
    [SerializeField] private Text questions; //shows the question on the screen
    [SerializeField] private Text numberText; //shows the number of the question
    [SerializeField] private int numberQuestion;//question number
    private int index; //saves the button's index
    [SerializeField] private int valueA; //puts the response in the first button in the response array
    [SerializeField] private int valueB; //puts the response in the second button in the response array
    [SerializeField] private int valueC; //puts the answer in the third button in the answer array
    [SerializeField] private int valueD; //puts the answer in the fourth button in the answer array
    private bool click; //checks if click
    private bool nextQuestions = true; //moves on to the next question 
    private int quest; //get the question in the quiz array

    public void IndexBtn(int i) //takes the button's index
    {
        index = i;
    }

    public void Select() //checks if you have clicked the button
    {
        click = true;
    }
    private void Update()
    {
        Questions();
        CheckAnswer();
        Answers();
        ExitGame();
    }

    void ExitGame() //leaves the game
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Questions() //moves on to the next question
    {
        if (nextQuestions) //checks to see if you got the previous question right
        {
            numberText.text = numberQuestion.ToString();
            nextQuestions = false;
            questions.text = quiz[quest];
        }
    }

    void CheckAnswer() //checks the answer 
    {
        switch (quest) //checks which question is in the array
        { 
            case 0:
                if(click && index == 2) //checks if you clicked on the button with the right index
                {
                    quest++; //moves on to the next question
                    numberQuestion++; //pass the question number
                    valueA += 4; //moves on to the next answer on the button1
                    valueB += 4; //moves on to the next answer on the button2
                    valueC += 4; //moves on to the next answer on the button3
                    valueD += 4; //moves on to the next answer on the button4
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 2) //checks if you clicked the wrong button
                {
                    SceneManager.LoadScene(3); //loads end-game scene
                }
                break;

            case 1:
                if (click && index == 2)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 2)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 2:
                if (click && index == 3)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 3)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 3:
                if (click && index == 3)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 3)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 4:
                if (click && index == 1)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 5:
                if (click && index == 3)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 3)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 6:
                if (click && index == 1)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 7:
                if (click && index == 4)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 4)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 8:
                if (click && index == 1)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 9:
                if (click && index == 3)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 3)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 10:
                if (click && index == 1)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 11:
                if (click && index == 2)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 2)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 12:
                if (click && index == 4)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 4)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 13:
                if (click && index == 2)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 2)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 14:
                if (click && index == 1)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 15:
                if (click && index == 4)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 4)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 16:
                if (click && index == 2)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 2)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 17:
                if (click && index == 1)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 18:
                if (click && index == 2)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 2)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 19:
                if (click && index == 3)
                {
                    quest++;
                    numberQuestion++;
                    valueA += 4;
                    valueB += 4;
                    valueC += 4;
                    valueD += 4;
                    nextQuestions = true;
                    click = false;
                }
                else if (click && index != 3)
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case 20:
                if (click && index == 1)
                {
                    SceneManager.LoadScene(2); //loads victory screen 
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;
        }
    }

    void Answers() //puts the array's responses into the buttons
    {
        switch (quest) //checks which question is in the array
        {
            case 0:
                Btn1.text = answer[valueA]; //the button1 receives the response in the array
                Btn2.text = answer[valueB]; //the button2 receives the response in the array
                Btn3.text = answer[valueC]; //the button3 receives the response in the array
                Btn4.text = answer[valueD]; //the button4 receives the response in the array
                break;

            case 1:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 2:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 3:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 4:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 5:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 6:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 7:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 8:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 9:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 10:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 11:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 12:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 13:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 14:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 15:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 16:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 17:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 18:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 19:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 20:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 21:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;

            case 22:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
                break;
        }
    }
   
}
