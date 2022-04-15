using Infrastructure.Services;

namespace Infrastructure.StateMachine.GameStateMachine
{
    public interface IGameStateMachine : IService
    {
        void Enter<TState>() where TState : IState;
    }
}