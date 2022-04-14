using Infrastructure.Services.InputService;
using UnityEngine;

namespace Game.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour
    {
        public float Speed;
        public float RotationSpeed;

        private IInputService _input;
        private Rigidbody _rigidbody;

        private Vector3 _currentDirection;

        private void Awake()
        {
            _input = new InputService();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (HasInput())
            {
                MovePlayer();
                UpdateCurrentDirection();
                LookAtCurrentDirection();
            }
            else
            {
                LookAtPreviousDirection();
            }
        }

        private void MovePlayer() => 
            _rigidbody.velocity = _input.Direction * Time.fixedDeltaTime * Speed;

        private void LookAtCurrentDirection() =>
            _rigidbody.rotation = Quaternion.Slerp(transform.rotation, 
                Quaternion.LookRotation(_currentDirection), 
                Time.deltaTime * RotationSpeed);

        private void UpdateCurrentDirection() => 
            _currentDirection = _input.Direction;

        private void LookAtPreviousDirection() => 
            _rigidbody.rotation = Quaternion.LookRotation(_currentDirection);

        private bool HasInput() => 
            _input.Direction != Vector3.zero;
    }
}