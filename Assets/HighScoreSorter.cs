using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScoreSorter : MonoBehaviour
{
    [SerializeField]private GameObject _scoreTemplate;
    private List<GameObject> highscoreEntryGameObject;


    private void Awake()
    {
        _scoreTemplate = GameObject.Find("ScoreTemp");
    }

    private void CreateHighScore(int HighScore)
    {

    }
 }
