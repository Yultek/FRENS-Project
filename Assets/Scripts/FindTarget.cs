using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class FindTarget : MonoBehaviour
{
    public NavMeshAgent NPC;
    public float aggroDistance = 10f;

    public Transform[] targets;
    public Material defaultMaterial;
    public Material targetedMaterial;

    private bool isAggro = false;
    private Transform currentTarget;
    private float targetTimer = 0f;
    public float targetSelectionInterval = 5f;

    private Renderer currentTargetRenderer;

    private void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Select(targetGO => targetGO.transform).ToArray();
        SelectNewTarget();
    }

    private void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, currentTarget.position);

        if (distanceToTarget <= aggroDistance)
        {
            if (NPC.isOnNavMesh)
            {
                NPC.SetDestination(currentTarget.position);

                if (!isAggro)
                {
                    isAggro = true;
                    SetMaterial(targetedMaterial);
                    // Additional actions when becoming aggressive
                }
            }
        }
        else
        {
            NPC.ResetPath();

            if (isAggro)
            {
                isAggro = false;
                SetMaterial(defaultMaterial);
                // Additional actions when returning to non-aggressive state
            }
        }

        targetTimer += Time.deltaTime;

        if (targetTimer >= targetSelectionInterval)
        {
            SelectNewTarget();
            targetTimer = 0f;
        }
    }

   private void SelectNewTarget()
{
    SetMaterial(defaultMaterial); // Reset the material to default
    currentTarget = targets[Random.Range(0, targets.Length)];
    currentTargetRenderer = currentTarget.GetComponent<Renderer>();
    SetMaterial(targetedMaterial); // Set the material to targeted material

    Debug.Log("Current Target: " + currentTarget.name);
    Debug.Log("Material Changed for: " + currentTarget.name);
}



    private void SetMaterial(Material material)
    {
        if (currentTargetRenderer != null)
        {
            currentTargetRenderer.material = material;
        }
    }
}
