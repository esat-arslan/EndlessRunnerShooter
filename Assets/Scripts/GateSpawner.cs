using System;
using System.Collections;
using System.Collections.Generic; 
using Unity.Mathematics;
using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public ObjectPool gatePool;
    public float spawnInternal = 3f;
    public float distance = 30f;
    public float deactivateDistance = 10f; // Distance behind player to deactivate gates
    [SerializeField] Transform player;

    private List<GameObject> activeGates = new List<GameObject>();

    IEnumerator SpawnGate()
    {
        while (true)
        {
            spawnGate();
            yield return new WaitForSeconds(spawnInternal);
        }
    }
    
    private void spawnGate()
    {
        List<GameObject> gates = gatePool.GetTwoPooledObjects();

        if (gates.Count < 2)
        {
            Debug.LogWarning("Not enough gates in pool");
            foreach (var gate in gates)
            {
                gate.SetActive(false);
            }
            return;
        }

        GameObject gate1 = gates[0];
        GameObject gate2 = gates[1];
 

        Vector3 spawnPos1 = player.position + player.forward * 1f + new Vector3(2.0f, 2.4f, distance);
        gate1.transform.position = spawnPos1;
        gate1.transform.rotation = Quaternion.identity;

        Vector3 spawnPos2 = player.position + player.forward * 1f + new Vector3(-2.0f, 2.4f, distance);
        gate2.transform.position = spawnPos2;
        gate2.transform.rotation = Quaternion.identity;

        gate1.SetActive(true);
        gate2.SetActive(true);
        
        // Add both gates to the active list
        activeGates.Add(gate1);
        activeGates.Add(gate2);
    }

    void Update()
    {
        // Check and deactivate gates that are too far behind the player
        for (int i = activeGates.Count - 1; i >= 0; i--)
        {
            if (activeGates[i] == null)
            {
                activeGates.RemoveAt(i);
                continue;
            }

            float distanceBehindPlayer = player.position.z - activeGates[i].transform.position.z;
            if (distanceBehindPlayer > deactivateDistance)
            {
                activeGates[i].SetActive(false);
                activeGates.RemoveAt(i);
            }
        }
    }

    void Start()
    {
        StartCoroutine(SpawnGate());
    }
}
