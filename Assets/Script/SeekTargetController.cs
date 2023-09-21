using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekTargetController : MonoBehaviour
{
    public Transform transformT;
    public SeekBehaviour seek;

    private void Start()
    {
        transformT = GameObject.FindWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transformT)
        {
            seek.Target = transformT.position;
        }
          
            
    }
}
