using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour 
{
    public float onscreenDelay = 5f;

	void Update () 
    {
        Destroy(this.gameObject, onscreenDelay);
	}
}
