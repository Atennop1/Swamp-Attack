using System;
using System.Collections.Generic;

namespace SwampAttack.Runtime.Model.AI.StateMachine
{
    public class Transition
    {
        public Func<bool> Condition {get; }
        public IState To { get; }
        public IEnumerable<Type> Exceptions { get; }

        public Transition(IState to, Func<bool> condition, IEnumerable<Type> exceptions)
        {
            To = to;
            Condition = condition;
            Exceptions = exceptions;
        }
    }
}