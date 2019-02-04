using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour 
{
	private void OnTriggerEnter(Collider other)
	{
        if(other.name == "Player")
        {
            Debug.Log("Enemy detected!");
        }
	}

	private void OnTriggerExit(Collider other)
	{
        if(other.name == "Player")
        {
            Debug.Log("Enemy out of range.");
        }
	}

}
