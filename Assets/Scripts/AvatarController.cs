using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    public GameObject seat;
    public GameObject leftPedal;
    public GameObject rightPedal;
    private Animator animator;

    public GameObject rightHandle;
    public GameObject leftHandle;

    public GameObject steer;

    [Range(0, 2)]
    public float bentOver=0.5f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = this.transform.localRotation;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.transform.position=seat.transform.position;
    }

    async void OnAnimatorIK(int layerIndex)
    {

        animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
        animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);

        animator.SetIKPosition(AvatarIKGoal.LeftFoot, leftPedal.transform.position);
        animator.SetIKPosition(AvatarIKGoal.RightFoot, rightPedal.transform.position);

        
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);

        animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandle.transform.position);
        animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandle.transform.position);
        animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandle.transform.rotation);
        animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandle.transform.rotation);

        animator.SetLookAtWeight(1, 1, 0, 1);
        animator.SetLookAtPosition(this.transform.position+steer.transform.right * bentOver);

    }

    void LateUpdate()
    {
        //TODO: Animate the neck to look forward
    }
}
