
using UnityEngine;
namespace platypus.CodingProficiency
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField]
        private float horizontal;
        [SerializeField]
        private float vertical;
        [SerializeField]
        private float speed = 5f;

        // Update is called once per frame
        void Update()
        {
            HandleInput();
            Movement();
        }

        private void Movement()
        {
            Vector3 move = new Vector3(horizontal, 0, vertical).normalized;
            transform.Translate(move * speed * Time.deltaTime);
        }

        private void HandleInput()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("V ertical");
        }
    }
}