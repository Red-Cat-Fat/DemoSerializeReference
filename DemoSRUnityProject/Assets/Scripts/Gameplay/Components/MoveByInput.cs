using UnityEngine;

namespace Gameplay
{
    public class MoveByInput : MonoBehaviour
    {
        public Rigidbody Body;
        public float Speed;

        private void FixedUpdate()
        {
            var moveVector = Vector3.zero;
            if (Input.GetKey(KeyCode.A))
                moveVector += Vector3.left;
            if (Input.GetKey(KeyCode.D))
                moveVector += Vector3.right;
            if (Input.GetKey(KeyCode.W))
                moveVector += Vector3.forward;
            if (Input.GetKey(KeyCode.S))
                moveVector += Vector3.back;
            var newPosition = Body.position + moveVector.normalized * Speed * Time.fixedDeltaTime;
            Body.MovePosition(newPosition);
        }
    }
}
