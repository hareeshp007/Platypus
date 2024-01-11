
using UnityEngine;
namespace platypus.CodingProficiency
{
    public class RotateyAxis : MonoBehaviour
    {
        public float rotationSpeed = 30f;

        void Update()
        {
            // Rotate the GameObject around its Y-axis continuously
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}