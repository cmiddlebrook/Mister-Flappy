using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshPro _scoreText;
    [SerializeField] private int _scorePerBricks = 100;

    private int _score;

    public void BirdPassedBricks()
    {
        _score += _scorePerBricks;
        _scoreText.text = _score.ToString();
    }

}
