using Infrastructure.Services.InputService;
using UnityEngine;

namespace Game.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour
    {
        public float MoveSpeed;

        private IInputService _input;
        private Rigidbody _rigidbody;

        private Vector3 _currentDirection;

        private void Awake()
        {
            _input = new InputService();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (_input.HasInput)
            {
                MovePlayer();
            }
        }

        private void MovePlayer() => 
            _rigidbody.velocity = _input.Direction.normalized * MoveSpeed * Time.fixedDeltaTime;
    }
}