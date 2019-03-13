using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int carDoors = 4;
    public int firstNumber = 2;
    public int secondNumber = 3;
    public int currentGold = 32;
    public int diceRoll = 7;
    public int playerLives = 3;

    public float pi = 3.14f;

    public string firstName = "Bilbo";
    public string rareItem = "Relic Stone";

    public string characterAction = "Attack";

    public bool allGood = true;
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;

    // Use this for initialization
    void Start()
    {
        Debug.Log(2 + 4);
        Debug.Log(carDoors - 2);

        AddNumbers();

        // Debug.Log(firstName + allGood);

        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.LogFormat("Next skill at level {0}", nextSkillLevel);

        PocketChange();
        OpenTreasureChamber();
        SwitchingAround();


        List<string> questPartyMembers = new List<string>() { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight" };
        questPartyMembers.Add("Craven the Necromancer");
        questPartyMembers.Insert(1, "Tanis the Thief");

        //questPartyMembers.RemoveAt(0);
        questPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5},
            { "Antidote", 7},
            { "Aspirin", 1}
        };

        int numberOfPotions = itemInventory["Potion"];
        itemInventory["Potion"] = 10;

        itemInventory.Add("Throwing Knife", 3);
        itemInventory["Bandages"] = 5;

        if(itemInventory.ContainsKey("Aspirin"))
        {
            itemInventory["Aspirin"] = 3;
        }

        itemInventory.Remove("Antidote");
        Debug.LogFormat("Items: {0}", itemInventory.Count);

        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

            if(questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }

        foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }

        foreach (KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }

        while(playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }

        Debug.Log("Player KO'd...");
    }

    // Update is called once per frame
    void Update()
    {

    }

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

    public void PocketChange()
    {
        if (currentGold > 50)
        {
            Debug.Log("You're rolling in it - beware of pickpockets.");
        }
        else if (currentGold < 15)
        {
            Debug.Log("Not much there to steal.");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
      }
    }

    public void OpenTreasureChamber()
    {
        if(pureOfHeart && rareItem == "Relic Stone")
        {
            if(!hasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    public void SwitchingAround()
    {
        switch (characterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }

        switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }
}
