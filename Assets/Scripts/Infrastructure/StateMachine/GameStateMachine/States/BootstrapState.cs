using Infrastructure.DI;
using Infrastructure.Services.InputService;

namespace Infrastructure.StateMachine.GameStateMachine.States
{
    public class BootstrapState : IState
    {
        private readonly IGameStateMachine _gameStateMachine;

        public BootstrapState(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
            
            RegisterServices();
        }
        
        public void Exit()
        {
            
        }

        public void Enter()
        {
            
        }

        private void RegisterServices()
        {
            RegisterStateMachine();
            RegisterInputSystem();
        }

        private void RegisterInputSystem() => 
            SimpleDI.Container.RegisterSingle<IInputService>(new InputService());

        private void RegisterStateMachine() => 
            SimpleDI.Container.RegisterSingle<IGameStateMachine>(_gameStateMachine);
    }
}