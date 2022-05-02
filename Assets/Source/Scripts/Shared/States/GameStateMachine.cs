using Source.Scripts.Core.StateMachine;
using Zenject;

namespace Source.Scripts.Shared.States {
    public class GameStateMachine : IInitializable {
        private StateMachine<State, Trigger> _stateMachine;

        public GameStateMachine() {
            _stateMachine = new StateMachine<State, Trigger>(State.None);
        }

        public void Initialize() {
            ConfigureStates();
        }

        private void ConfigureStates() {
            
        }
    }
}
