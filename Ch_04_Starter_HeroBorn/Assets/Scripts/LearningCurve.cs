using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int carDoors = 4;
    public int firstNumber = 2;
    public int secondNumber = 3;

    public float pi = 3.14f;
    public string firstName = "Bilbo";
    public bool allGood = true;

    // Use this for initialization
    void Start()
    {
        Debug.Log(2 + 4);
        Debug.Log(carDoors - 2);

        AddNumbers();

        Debug.Log($"A string can have variables like {firstName} inserted directly!");
        // Debug.Log(firstName + allGood);

        int characterLevel = 3;
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

    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }
}
