using System;
using SwampAttack.Runtime.AI.Enemies.Interfaces;
using SwampAttack.Runtime.AI.StateMachine;

namespace SwampAttack.Runtime.AI.Enemies.Minotaur.States
{
    public sealed class VictoryState : IState
    {
        private readonly IEnemyTransformView _enemyTransformView;

        public VictoryState(IEnemyTransformView enemyTransformView)
        {
            _enemyTransformView = enemyTransformView ?? throw new ArgumentException("EnemyView can't be null");
        }

        public void OnEnter()
        {
            _enemyTransformView.PlayAnimation("Victory");
        }

        public void Tick() { }
        public void OnExit() { }
    }
}