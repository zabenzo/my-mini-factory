using UnityEngine;

namespace Infrastructure.Services.InputService
{
    public interface IInputService : IService
    {
        Vector3 Direction { get; }
        bool HasInput { get; }
    }
}