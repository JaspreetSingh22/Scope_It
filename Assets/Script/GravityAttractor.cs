using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour
{
    public float gravity = -10f;
    public void Attract(Transform body, Rigidbody bodyRigidBody)

    {
        Vector3 gravityup = (body.position - transform.position).normalized;
        Vector3 bodyup = body.up;

        bodyRigidBody.AddForce(gravityup * gravity);
        Quaternion targetRotation = Quaternion.FromToRotation(bodyup, gravityup) * body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50*Time.deltaTime);
    }
}
