namespace Infrastructure.StateMachine.GameStateMachine
{
    public interface IGameStateMachine
    {
        void Enter<TState>() where TState : IState;
    }
}