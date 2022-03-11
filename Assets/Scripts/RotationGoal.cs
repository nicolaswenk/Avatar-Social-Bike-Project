using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGoal : MonoBehaviour
{
    public Transform rotationGoal;

    private Quaternion initialRotation;
    private Quaternion goalInitialRotation;

    private void Start()
    {
        initialRotation = this.transform.rotation;
        goalInitialRotation = this.rotationGoal.rotation;
    }

    void Update(){
        this.transform.rotation = initialRotation * Quaternion.Inverse(goalInitialRotation) * rotationGoal.rotation;
    }
}
