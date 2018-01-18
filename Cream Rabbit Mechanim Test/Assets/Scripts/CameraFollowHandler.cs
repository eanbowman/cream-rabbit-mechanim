using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraFollowHandler : MonoBehaviour
{
    public Transform followTarget;
    public float speed;
    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, 3, 0);
        Debug.Log(followTarget);
    }

    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //transform.position = followTarget.transform.position + offset;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, followTarget.position - (followTarget.forward * 10.0f) + offset, step);
        transform.LookAt(followTarget.position);
    }

    public void SetFollowTarget(GameObject newTarget)
    {
        this.followTarget = newTarget.transform;
    }
}