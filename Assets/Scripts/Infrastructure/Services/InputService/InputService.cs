using UnityEngine;

namespace Infrastructure.Services.InputService
{
    public class InputService : IInputService
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";

        public Vector3 Direction => 
            new Vector3(SimpleInput.GetAxis(HorizontalAxisName), 0.0f, SimpleInput.GetAxis(VerticalAxisName));
        public bool HasInput => Direction != Vector3.zero;
    }
}