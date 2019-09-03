using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events; // Use Unity's Event System
// Custom Unity Event for Functions with Int Arguments
public class ScoreAddedEvent : UnityEvent<int> { } 

public class GameManager : MonoBehaviour
{
    #region Singleton
    // Singleton Code goes here
    public static GameManager Instance = null;
    private void Awake()
    {
        // Assign the Single Instance upon Awake!
        Instance = this;
    }
    #endregion

    public ScoreAddedEvent onScoreAdded = new ScoreAddedEvent();
    public int totalScore = 0; // Score Keeper Value

    // Function to Add Score to the GameManager
    // e.g, AddScore(1) or AddScore(2)
    public void AddScore(int scoreToAdd)
    {
        // Increase TotalScore by scoreToAdd value
        totalScore += scoreToAdd;
        // Invoke the OnScoreAdded event
        onScoreAdded.Invoke(totalScore);
    }
}
