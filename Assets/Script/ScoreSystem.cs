using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public float scoreMultiplier;
    public const string highScoreKey = "HighScore";

    private float score;

    private void Update()
    {
        score += Time.deltaTime * scoreMultiplier;
        scoreTxt.text = Mathf.FloorToInt(score).ToString("00000");
    }
}
