using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Movement
{

    public float speed;

    public Movement MoveCharacter(Transform transform, Vector3 direction, float frame) {
        // transform.position = Vector3.MoveTowards(transform.position, target, frame * speed);
        transform.Translate(direction * frame * speed);
        return this;
    }

    // public Movement MoveCharacter(Transform transform, Vector3 direction, float frame) {
    //     // transform.TransformDirection = Vector3.MoveTowards(transform.position, target.position, frame * speed);
    //     transform.Translate(direction * frame * speed);
    //     return this;
    // }

}
