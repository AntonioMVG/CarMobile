using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public float scoreMultiplier;
    public const string highScoreKey = "HighScore";
    
    private CarController carController;
    private float score;

    private void Start()
    {
        carController = GameObject.Find("Car").GetComponent<CarController>();
    }

    private void Update()
    {
        score += Time.deltaTime * scoreMultiplier * carController.speed;
        scoreTxt.text = Mathf.FloorToInt(score).ToString("00000");
    }
}
