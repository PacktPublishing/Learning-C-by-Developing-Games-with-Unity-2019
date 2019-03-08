using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour 
{
    public Vector3 offset;

    private Transform playerPos;

	void Start()
	{
        playerPos = GameObject.Find("Player").transform;
	}

	void LateUpdate()
    {
        this.transform.position = playerPos.TransformPoint(offset);
        this.transform.LookAt(playerPos);
    }
}
