using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class troopScript : MonoBehaviour
{

    private NavMeshAgent _agent;
    private Vector3 _destination;


    // Start is called before the first frame update
    void Start()
    {
        _agent = this.GetComponent<NavMeshAgent>();
        _destination = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        _agent.destination = _destination;
    }

    public void SetDestination(Vector3 dest)
    {
        _destination = dest;
    }
}
