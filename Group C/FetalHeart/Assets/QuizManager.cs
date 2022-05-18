using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text QuestionText;
    public GameObject quizPanel;
    public GameObject gPanel;
    public Text ScoreText;
    public GameObject imageQuestion;

    int totalQuestions = 0;
    public int score;
    int answeredQuestions = 0;
    int maxQuestions = 5;

    private void Start()
    {
        totalQuestions = QnA.Count;
        gPanel.SetActive(false);
        GenerateQuestion();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        quizPanel.SetActive(false);
        gPanel.SetActive(true);
        ScoreText.text = score + "/" + maxQuestions;
    }

    public void Correct()
    {
        score += 1;
        answeredQuestions += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        options[QnA[currentQuestion].CorrectAnswer-1].GetComponent<Image>().color = Color.green;
        answeredQuestions += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
        
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        GenerateQuestion();
    }


    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript>().startColor;
            // options[i].GetComponent<Image>().color = Color.white;
            options[i].GetComponent<AnswerScript>().isCorrect = false;

            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];


            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void GenerateQuestion()
    {   
        // if(QnA.Count > 0)
        if(answeredQuestions < maxQuestions)
        {
            currentQuestion = Random.Range(0,QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;

            imageQuestion.GetComponent<Image>().sprite = QnA[currentQuestion].Image;

            SetAnswers();
        }
        else
        {
            Debug.Log("Finished");
            GameOver();
        }
        
    }
}
