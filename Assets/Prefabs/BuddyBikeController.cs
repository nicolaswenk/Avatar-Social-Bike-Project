//using Normal.Realtime;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BuddyBikeController : MonoBehaviour
{
    [SerializeField]
    private Animator wheelsAnimator;

    [SerializeField]
    private Animator pedalAnimator;

    [Range(0.0f, 10.0f)]
    public float RotationSpeed = 0;

    [SerializeField]
    private Transform player1Transform;

    [SerializeField]
    private Transform player2Transform;


    #region Private Methods

    private void Awake()
    {
        wheelsAnimator.speed = 1;
        pedalAnimator.speed = 2;


    }

    private void OnEnable()
    {
        //thisFollower = splineController.AssignSplineFollower(gameObject);
    }

    //public void AddPlayer(PlayerController player)
    //{
    //    playersOnBike.Add(player);
    //}

    private void Update()
    {
        //if (playersOnBike.Count < 1) return;

        //float sharedSpeed = playersOnBike.Select(player => player.Speed).Sum();
        float wheelSpeed = Mathf.Clamp(RotationSpeed, -5, 5);
        wheelsAnimator.speed = wheelSpeed;

        pedalAnimator.speed = wheelSpeed/2;

        //if (thisFollower != null)
        //    SplinePlusAPI.Follower_Set_Speed(thisFollower, sharedSpeed);
    }

    #endregion Private Methods
}