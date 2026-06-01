using System;
using System.Net.Mime;
using NUnit.Framework.Internal;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoremanager1 : MonoBehaviour
{
    public static Scoremanager1 instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI winText;

    [SerializeField] int score = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = score.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        score++;
        text.text = score.ToString();
        //text.text += scoreToAdd.ToString();
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("button works");
    }

    public void Update()
    {
       ScoreReached();
    }

    public void ScoreReached()
    {
        if (score == 14)
        {
            winText.gameObject.SetActive(true);
            text.gameObject.SetActive(false);
        }
    }
}
