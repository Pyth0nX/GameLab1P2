using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CattoMeter : MonoBehaviour
{
    public Slider powerUpSlider; // Reference to the UI Slider
    public float maxPower = 100f; // Maximum value of the power-up bar
    private float currentPower; // Current value of the power-up bar
    public float speed = 1f;

    void Start()
    {
        // Initialize the slider's maximum value and current value
        powerUpSlider.maxValue = maxPower;
        currentPower = powerUpSlider.value;
       // powerUpSlider.value = currentPower;
    }

    public void IncreasePower(float powerAmount)
    {
        // Increase the current power by the powerAmount, making sure it doesn't exceed maxPower
        currentPower += powerAmount;
        currentPower = Mathf.Clamp(currentPower, 0f, maxPower);

        // Update the slider's value
        powerUpSlider.value = currentPower;
    }

    public void DecreasePower(float powerAmount)
    {
        // Decrease the current power by the powerAmount, making sure it doesn't exceed maxPower
        currentPower -= powerAmount;
        currentPower = Mathf.Clamp(currentPower, 0f, maxPower);

        //Update the slider's value
        powerUpSlider.value = currentPower;
    }

   // public void ResetPower()
   // {
        // Reset the power-up bar to zero
    //    currentPower = 0f;
    //    powerUpSlider.value = currentPower;
  //  }

    public void Update()
    {
        powerUpSlider.value -= Time.deltaTime * speed;
        currentPower = powerUpSlider.value;

        if (currentPower <= 0f)
        {
            SceneManager.LoadScene("RetryGame");
        }
    }
}