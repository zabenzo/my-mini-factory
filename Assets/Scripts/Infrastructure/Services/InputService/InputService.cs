using UnityEngine;

namespace Infrastructure.Services.InputService
{
    public class InputService : IInputService
    {
        private Vector3 _direction;
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
        
        public Vector3 Direction
        {
            get
            {
                float xDirection = SimpleInput.GetAxis(HorizontalAxisName);
                float zDirection = SimpleInput.GetAxis(VerticalAxisName);
                return new Vector3(xDirection, 0.0f, zDirection);
            }
        }
    }
}