using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class ScoreAdder : MonoBehaviour
{
    private int _currentScore;
    public TMP_Text HighScore, CurrentScore;
    public AudioSource pointSource;
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
        CurrentScore.text = "0";
        _currentScore = 0;
        HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        _animator.SetBool("jumping", true);

        if(col.gameObject.tag == "DefaultPlatform"){
            _currentScore++;
            string StringScore = _currentScore.ToString();
            CurrentScore.text = StringScore;
            col.gameObject.tag = "JumpedOn";
            pointSource.pitch = Random.Range(0.9f, 1.1f);
            pointSource.Play(0);
            CheckHighScore();
         }         
    }

    void CheckHighScore()
    {
        if(_currentScore > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", _currentScore);
            int _highScore = PlayerPrefs.GetInt("HighScore");
            _highScore = _highScore + 2;
            string _StringHighScore = _highScore.ToString();
            HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }

    void JumpFalse()
    {
        _animator.SetBool("jumping", false);
    }
}