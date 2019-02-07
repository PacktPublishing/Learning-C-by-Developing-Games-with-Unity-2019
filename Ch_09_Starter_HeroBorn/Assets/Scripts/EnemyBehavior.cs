using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
        if (other.name == "Player")
        {
            Debug.Log("Enemy detected!");
        }
	}

	void OnTriggerExit(Collider other)
	{
        if(other.name == "Player")
        {
            Debug.Log("Enemy out of range.");
        }
	}
}
