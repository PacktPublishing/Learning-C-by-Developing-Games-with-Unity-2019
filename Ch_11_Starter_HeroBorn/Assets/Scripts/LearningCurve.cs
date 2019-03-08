using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour 
{
    private int firstNumber = 2;

    public int secondNumber = 3;
    public float pi = 3.14f;
    public string characterName = "Bilbo";
    public bool allGood = true;

    public Transform camTransform;
    public GameObject directionLight;
    public Transform lightTransform;

    // Use this for initialization
    void Start()
    {
        int characterLevel = 32;

        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));
    }

    void LoopExample()
    {
        int playerLives = 3;

        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }

        Debug.Log("Player KO'd...");
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }

    public void DisplaySkillProgression(int level)
    {
        Debug.LogFormat("New skill available at level {0}", level);
    }

    /// <summary>
    /// Adds the numbers.
    /// </summary>
    void AddNumbers()
    {
        Debug.Log(firstNumber + secondNumber);
    }

    void GetComponentExample()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

    void OOPExample()
    {
        Character hero = new Character();
        Character hero2 = hero;

        hero2.name = "Sir Krane the Brave";

        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();
        Weapon huntingBow = new Weapon("Hunting Bow", 105);

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
    }
}