
using UnityEngine;

namespace platypus.ProblemSolving
{
    public class WallBounce : MonoBehaviour
    {
        [SerializeField]
        private Vector3 initialVelocity;

        [SerializeField]
        private float minVelocity = 10f;

        private Vector3 lastFrameVelocity;
        private Rigidbody rb;

        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();
            rb.velocity = initialVelocity;
        }

        private void Update()
        {
            lastFrameVelocity = rb.velocity;
        }

        private void OnCollisionEnter(Collision collision)
        {
            //Getting the normal of the collided Gameobject in this case a wall
            Bounce(collision.contacts[0].normal);
        }

        private void Bounce(Vector3 collisionNormal)
        {
            var speed = lastFrameVelocity.magnitude;
            //getting direcion from the normalized rigidbody Velocity and collision normal 
            var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

            Debug.Log("Out Direction: " + direction);
            //changing the direction of velocity
            rb.velocity = direction * Mathf.Max(speed, minVelocity);
        }
    }
}
/*In a scenario where you need to optimise the performance of a Unity game,
 * what are some strategies or techniques you would consider?
 * 
 * Use Object Pooling:
 * Instead of instantiating and destroying objects frequently, use object pooling to reuse existing objects. 
 * This reduces memory allocations and garbage collection overhead.
 * Batching:
 * Combine multiple smaller meshes into a single, larger mesh to reduce draw calls. 
 * Unity automatically batches static objects, but dynamic objects may benefit from manual batching.
 * Level of Detail (LOD):
 * Implement LOD for models to decrease polygon count at a distance, improving rendering performance.
 * Use the Unity Profiler:
 * Profile your game using the Unity Profiler to identify performance bottlenecks and optimize critical areas.
 * Code Optimization:
 * Optimize critical sections of code, avoid unnecessary calculations, and minimize the use of performance-intensive operations.
 
 */