using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CarController : MonoBehaviour
{
    public float speed;
    public float speedGainPerSecond;
    public float turnSpeed;
    public TMP_Text speedTxt;

    private int steerValue;

    // Update is called once per frame
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    public void Accelerate()
    {
        speed += 1;
        speedTxt.text = speed.ToString("Speed 00");
    }

    public void Decelerate()
    {
        speed -= 1;
        speedTxt.text = speed.ToString("Speed 00");
    }
}
