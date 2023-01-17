using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destino, destino2;
    // Start is called before the first frame update
    void Start()
    {
        agent.destination = destino.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destino.transform.position;
        float distancia = Vector3.Distance(transform.position, destino.transform.position);
        if (distancia < 3)
        {
            agent.destination = destino2.transform.position;
        }

    }
}
