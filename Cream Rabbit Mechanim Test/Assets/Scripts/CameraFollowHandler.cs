using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraFollowHandler : MonoBehaviour
{
    public Transform followTarget;
    //private Vector3 offset;

    void Start()
    {
        //offset = transform.position;
        Debug.Log(followTarget);
    }

    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //transform.position = followTarget.transform.position + offset;
        NavMeshAgent nma = gameObject.GetComponent<NavMeshAgent>();
        nma.SetDestination(followTarget.position);
        transform.LookAt(followTarget.position);
    }

    public void SetFollowTarget(GameObject newTarget)
    {
        this.followTarget = newTarget.transform;
    }
}