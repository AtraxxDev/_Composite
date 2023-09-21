using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAwayTargetController : MonoBehaviour
{
    public Transform transformT;
    public RunAwayBehaviour runAway;


    // Update is called once per frame
    void Update()
    {
        runAway.Target = transformT.position;

    }
}
