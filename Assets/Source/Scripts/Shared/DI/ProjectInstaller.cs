using Source.Scripts.Shared.States;
using Zenject;

namespace Source.Scripts.Shared.DI {
    public class ProjectInstaller : MonoInstaller {
        public override void InstallBindings() {
            Container
                .BindInterfacesAndSelfTo<GameStateMachine>()
                .AsSingle()
                .NonLazy();
        }
    }
}