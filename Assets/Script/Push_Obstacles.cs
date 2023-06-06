using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Obstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public int forcemaniture = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rig = hit.collider.attachedRigidbody;
        if (rig != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rig.AddForceAtPosition(forceDirection * forcemaniture, transform.position, ForceMode.Impulse);
        }
    }
}
