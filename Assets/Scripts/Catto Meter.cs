using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CattoMeter : MonoBehaviour
{
    public Slider powerUpSlider; // Reference to the UI Slider
    public float maxPower = 100f; // Maximum value of the power-up bar
    private float _currentPower;
    private float currentPower
    {
        get
        {
            return _currentPower;
        }
        set
        {
            if (_currentPower != value) {
                Debug.Log("Value Changed " + _currentPower + " " + gameObject.name);
            }
            _currentPower = value;
        }
    }
    public float speed = 1f;

    public void Start()
    {
        // Initialize the slider's maximum value and current value
        currentPower = maxPower;
        powerUpSlider.value = currentPower;
       // powerUpSlider.value = currentPower;
    }

    public void IncreasePower(float powerAmount)
    {
        // Increase the current power by the powerAmount, making sure it doesn't exceed maxPower
        currentPower += powerAmount;
    }

    public void DecreasePower(float powerAmount)
    {
        Debug.Log("changing power from: " + currentPower);
        // Decrease the current power by the powerAmount, making sure it doesn't exceed maxPower
        currentPower -= powerAmount;
        Debug.Log("to: " + currentPower);
    }

   // public void ResetPower()
   // {
        // Reset the power-up bar to zero
    //    currentPower = 0f;
    //    powerUpSlider.value = currentPower;
  //  }

    public void Update()
    {
        currentPower -= Time.deltaTime * speed;
        powerUpSlider.value = currentPower;

        if (currentPower <= 5f)
        {
            SceneManager.LoadScene("RetryGame");
        }
    }
}