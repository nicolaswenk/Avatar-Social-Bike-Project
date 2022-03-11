using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalRotator : MonoBehaviour
{
    public GameObject leftEnd;
    public GameObject rightEnd;

    public float tourProgress=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tourProgress = Time.time/5.0f;

        this.transform.localRotation = Quaternion.Euler(0,0,-tourProgress*360);
    }
}
