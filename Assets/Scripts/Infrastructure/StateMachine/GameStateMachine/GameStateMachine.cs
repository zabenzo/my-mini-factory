using System;
using System.Collections.Generic;
using Infrastructure.StateMachine.GameStateMachine.States;

namespace Infrastructure.StateMachine.GameStateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly Dictionary<Type, IState> _gameStates;
        
        private IState _activeState;

        public GameStateMachine()
        {
            _gameStates = new Dictionary<Type, IState>()
            {
                [typeof(BootstrapState)] = new BootstrapState(this),
            };
        }

        public void Enter<TState>() where TState : IState
        {
            _activeState.Exit();
            _activeState = _gameStates[typeof(TState)];
            _activeState.Enter();
        }
    }
}