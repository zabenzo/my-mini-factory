namespace Infrastructure.StateMachine.GameStateMachine
{
    public interface IState : IExitState
    {
        void Enter();
    }
}