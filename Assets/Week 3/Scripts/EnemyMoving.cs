using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] protected Transform target;
    [SerializeField] protected Transform target2;
    [SerializeField] protected Point pointtogo;
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Animator animator;
    [SerializeField] protected float distance;
    [SerializeField] protected float distanceAgent;
    [SerializeField] protected float distance2;
    [SerializeField] protected float stopdistance = 5;
    [SerializeField] protected bool isWalking;
    [SerializeField] protected bool idle;
    // Start is called before the first frame update

    void FixedUpdate()
    {
        //MovetoTarget();
        UpdateAnimator();
        MovetoTargetPoint();
    }
    void UpdateAnimator()
    {
        isWalking = !agent.isStopped;
        animator.SetBool("IsWalking", isWalking);

    }

    protected virtual void MovetoTarget()
    {
        Vector3 position = target.position; // vị trí worldspace
        distance = Vector3.Distance(transform.position, target.position);
        Vector3 position2 = target2.position; // vị trí worldspace
        distance2 = Vector3.Distance(transform.position, target2.position);
        distanceAgent = agent.remainingDistance;
        if (stopdistance <= distance2)
        {
            if (distance > distance2)
            {
                agent.isStopped = false;
                agent.SetDestination(position2);
                Debug.Log("Target2 gan hon" + " ID: " + transform.position);

            }
        }
        else
            agent.isStopped = true;
        if (stopdistance <= distance)
        {
            if (distance < distance2)
            {
                agent.isStopped = false;
                agent.SetDestination(position);
                Debug.Log("Target1 gan hon" + " ID: " + transform.position);
            }
        }
        else
            agent.isStopped = true;

    }
    protected virtual void MovetoTargetPoint()
    {
        if (pointtogo == null) return;
        Vector3 position = pointtogo.transform.position; // vị trí worldspace
        distance = Vector3.Distance(transform.position, pointtogo.transform.position);
        if (stopdistance <= distance)
        {
            {
                agent.isStopped = false;
                agent.SetDestination(position);
            }
        }
        else // nếu đến đích thì animation dừng và cập nhật điểm mới
        {
            pointtogo = pointtogo.Nextpoint;
            agent.isStopped = true;
        }

    }

}




