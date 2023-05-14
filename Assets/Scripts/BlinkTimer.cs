using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkTimer : MonoBehaviour
{
    public float totalBlinkTime = 20f;
    public float currentBlinkTime;
    public int totalBlinks;

    private ObjectState[] objectArray;

    public Slider slider;
    public GameObject gameOver;

    public int Smoothing = 2;

    // Start is called before the first frame update
    void Start()
    {
        currentBlinkTime = totalBlinkTime;

        objectArray = FindObjectsOfType(typeof(ObjectState)) as ObjectState[];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBlinkTime == totalBlinkTime)
        {
            // Make all bject more creature-like
            foreach (ObjectState objectState in objectArray)
            {
                objectState.ProgressState(totalBlinks);
            }
        }

        currentBlinkTime -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Blink!");
            currentBlinkTime = totalBlinkTime;
            totalBlinks += 1;

            // play blink transition animation
        }

        if (slider.value != currentBlinkTime)
        {

            slider.value = Mathf.Lerp(slider.value, currentBlinkTime, Smoothing + Time.deltaTime);
            Debug.Log("whoooo");

        }

        if (currentBlinkTime <= 0 || totalBlinks >= 6)
        {
            GameOverUI gameOverUI = gameOver.GetComponent<GameOverUI>();
            gameOverUI.GameOver();
        }
    }
}
