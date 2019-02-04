using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour 
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    public float jumpVelocity = 5f;
    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;
    public GameObject bullet;
    public float bulletSpeed = 100f;

    private float _vInput;
    private float _hInput;
    private Rigidbody _rb;
    private CapsuleCollider _col;

	void Start()
	{
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
	}

	void Update()
	{
        _vInput = Input.GetAxis("Vertical") * moveSpeed;
        _hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }

        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
	}

	void FixedUpdate()
	{
        Vector3 rotation = Vector3.up * _hInput * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(rotation);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet, this.transform.position, this.transform.rotation) as GameObject;
            newBullet.transform.Translate(0f, 0.1f, 1.5f);
            Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
            bulletRB.velocity = this.transform.forward * bulletSpeed;
        }
	}

    private bool IsGrounded()
    {
        Vector3 endPosition = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        return Physics.CheckCapsule(_col.bounds.center, endPosition, distanceToGround, groundLayer, QueryTriggerInteraction.Ignore);
    }
}
