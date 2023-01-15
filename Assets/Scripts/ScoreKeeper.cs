using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public Text _scoreCount;
    void Start()
    {
        _scoreCount = GameObject.Find("Score").GetComponent<Text>();
    }
}