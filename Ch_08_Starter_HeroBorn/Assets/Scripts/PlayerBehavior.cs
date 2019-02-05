using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour 
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float _vInput;
    private float _hInput;
    private Rigidbody _rb;

	void Start()
	{
        _rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
        _vInput = Input.GetAxis("Vertical") * moveSpeed;
        _hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
	}

	void FixedUpdate()
	{
        Vector3 rotation = Vector3.up * _hInput * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(rotation);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);
	}
}
