using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // 1. Defining Variables
    public int carDoors = 4;

    // 2. Method to the Madness
    public int firstNumber = 2;
    public int secondNumber = 3;

    // 3. Working with Types
    public float pi = 3.14f;
    public string firstName = "Bilbo";
    public bool allGood = true;

    // Use this for initialization
    void Start()
    {
        // 1. 
        Debug.Log(2 + 4);
        Debug.Log(carDoors - 2);

        // 2.
        AddNumbers();

        // 3. 
        // Debug.Log(firstName + allGood);

        // 4 - 6
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.LogFormat("Next skill at level {0}", nextSkillLevel);
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

    // 4. Defining Methods
    // 5. Specifying Parameters
    // 6. Specifying Return Values
    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }
}
