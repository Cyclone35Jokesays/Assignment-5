using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickMove : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent nAgent;
    private bool amRunning = false;
    private bool amAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        nAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                nAgent.destination = hit.point;
            }
        }

        if (Input.GetMouseButton(1))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                nAgent.destination = hit.point;
            }
        }

        if (nAgent.remainingDistance <= nAgent.stoppingDistance)
        {
            amRunning = false;
            amAttacking = false;
        }

        else
        {
            amRunning = true;
            amAttacking = true;
        }
        anim.SetBool("Walks", amRunning);
        anim.SetBool("Walks", amAttacking);
    }
}
