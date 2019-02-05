using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int carDoors = 4;
    public int firstNumber = 2;
    public int secondNumber = 3;

    // Use this for initialization
    void Start()
    {
        Debug.Log(2 + 4);
        Debug.Log(carDoors - 2);

        AddNumbers();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// 2.
    /// <summary>
    /// Adds the numbers.
    /// </summary>
    void AddNumbers()
    {
        Debug.Log(firstNumber + secondNumber);
    }
}
