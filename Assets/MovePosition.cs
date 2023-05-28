using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    [SerializeField] Transform objectToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(objectToFollow.position.x,
            objectToFollow.position.y, transform.localPosition.z);
    }
}
