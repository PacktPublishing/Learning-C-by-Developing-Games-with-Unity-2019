using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour 
{
    public Transform player;
    public Transform patrolRoute;
    public List<Transform> locations;

    private int locationIndex = 0;
    private NavMeshAgent agent;
    private int _lives = 3;

    public int Lives 
    {
        get { return _lives; }
        private set 
        {
            _lives = value;

            if (_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemy down.");
            }
        }
    }

	void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.Find("Player").transform;

        InitializePatrolRoute();
        MoveToNextPatrolLocation();
	}

	void Update()
	{
        if (agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
	}

    void InitializePatrolRoute()
    {
        foreach (Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

	void MoveToNextPatrolLocation()
    {
        if (locations.Count == 0)
            return;
        
        agent.destination = locations[locationIndex].position;
        locationIndex = (locationIndex + 1) % locations.Count;
    }

	void OnTriggerEnter(Collider other)
	{
        if (other.name == "Player")
        {
            agent.destination = player.position;
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

	void OnCollisionEnter(Collision collision)
	{
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            Lives -= 1;
            Debug.Log("Critical hit!");
        }
	}
}
