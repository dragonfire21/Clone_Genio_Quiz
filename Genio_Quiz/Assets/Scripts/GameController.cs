using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class GameController : MonoBehaviour
{
    [Header("Arrays")]
    [SerializeField] private string[] quiz;
    [SerializeField] private string[] answer;

    [Header("Btn1")]
    [SerializeField] private Text Btn1;

    [Header("Btn2")]
    [SerializeField] private Text Btn2;

    [Header("Btn3")]
    [SerializeField] private Text Btn3;

    [Header("Btn4")]
    [SerializeField] private Text Btn4;

    [Header("Questions")]
    [SerializeField] private Text questions;
    [SerializeField] private Text numberText;
    [SerializeField] private int numberQuestion;
    private int index;
    [SerializeField] private int valueA;
    [SerializeField] private int valueB;
    [SerializeField] private int valueC;
    [SerializeField] private int valueD;
    private bool click;
    private bool nextQuestions = true;
    private int quest;

    public void IndexBtn(int i)
    {
        index = i;
    }

    public void Select()
    {
        click = true;
    }
    private void Update()
    {
        Questions();
        CheckAnswer();
        Answers();
    }

    void Questions()
    {
        if (nextQuestions)
        {
            numberText.text = numberQuestion.ToString();
            nextQuestions = false;
            questions.text = quiz[quest];
        }
    }

    void CheckAnswer()
    {
        switch (quest)
        {
            case 0:
                if(click && index == 2)
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
                    SceneManager.LoadScene(2);
                }
                else if (click && index != 1)
                {
                    SceneManager.LoadScene(3);
                }
                break;
        }
    }

    void Answers()
    {
        switch (quest)
        {
            case 0:
                Btn1.text = answer[valueA];
                Btn2.text = answer[valueB];
                Btn3.text = answer[valueC];
                Btn4.text = answer[valueD];
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
