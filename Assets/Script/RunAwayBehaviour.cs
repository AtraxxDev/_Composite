using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAwayBehaviour : SteeringBehaviour
{
    
    public float RunAwayCircle;
    public float safeRadius;


    public override Vector3 GetForce()
    {
        Position = transform.position;
        DesiredVelocity = (Position - Target).normalized * speed;
        Vector3 steering = DesiredVelocity - Velocity;
        Velocity = Vector3.ClampMagnitude(Velocity + steering, speed);

        var distance = Vector3.Distance(transform.position, Target);

        if (distance >= safeRadius)
        {
            Debug.Log($"Factor reducion: {distance/safeRadius}");
            var distanceFRadius = distance / safeRadius;
            DesiredVelocity = (DesiredVelocity).normalized * speed * (distanceFRadius);
            if (distanceFRadius <= 0.1)
            {
                return Vector3.zero;
            }
        }
        else
        {
            Debug.Log("Estoy Dentro");

            transform.position += Velocity * Time.deltaTime;
        }

       
        
        return steering;

    }
}
