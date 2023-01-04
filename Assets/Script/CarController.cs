using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CarController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public TMP_Text speedTxt;

    private int steerValue;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    public void Accelerate(int value)
    {
        speed += value;
        speedTxt.text = speed.ToString("00");
        speedTxt.color = Color.green;

        if (speed <= 0)
            speedTxt.color = Color.white;
    }

    public void Decelerate(int value)
    {
        speed -= value;
        speedTxt.text = speed.ToString("00");

        if(speed < 0)
            speedTxt.color = Color.red;
    }
}
