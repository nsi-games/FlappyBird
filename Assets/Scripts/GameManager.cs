using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class ScoreAddedEvent : UnityEvent<int> { }

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance = null;
    private void Awake()
    {
        // Set GameManager as single instance
        Instance = this;
    }
    #endregion

    public ScoreAddedEvent onScoreAdded = new ScoreAddedEvent();
    private int totalScore = 0;

    public void AddScore(int scoreToAdd)
    {
        // Add the score to total
        totalScore += scoreToAdd;

        // Invoke onScoreAdded Event
        onScoreAdded.Invoke(totalScore);
    }
}
