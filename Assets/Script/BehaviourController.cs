using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourController : MonoBehaviour
{

    public List<SteeringBehaviour>  behaviours = new List<SteeringBehaviour>();
    public Rigidbody rigidbody;
    public Vector3 velocity;
    public Vector3 totalForce = Vector3.zero;

    public void FixedUpdate()
    {
        {
            // Inicializar la fuerza en 0
            totalForce = Vector3.zero;
            //Sacar vector fuerza total
            foreach (SteeringBehaviour behaviour in behaviours)
            {
                totalForce += behaviour.GetForce();
            }
            // Movimiento
            velocity += totalForce;
            transform.position += velocity * Time.deltaTime;
        }
    }
    
}
