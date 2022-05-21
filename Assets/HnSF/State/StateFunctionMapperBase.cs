using System;
using System.Collections.Generic;
using HnSF.Fighters;

namespace HnSF
{
    [System.Serializable]
    public class StateFunctionMapperBase
    {
        public Dictionary<Type, Action<IFighterBase, IStateVariables, StateTimeline, int>> functions =
            new Dictionary<Type, Action<IFighterBase, IStateVariables, StateTimeline, int>>();

        public virtual bool TryRegisterFunction(Type id, Action<IFighterBase, IStateVariables, StateTimeline, int> function)
        {
            if (functions.ContainsKey(id)) return false;
            functions.Add(id, function);
            return true;
        }

        public virtual void RegisterFunction(Type id, Action<IFighterBase, IStateVariables, StateTimeline, int> function)
        {
            functions.Add(id, function);
        }

        public virtual bool OverrideFunction(Type id, Action<IFighterBase, IStateVariables, StateTimeline, int> function)
        {
            functions[id] = function;
            return true;
        }

        public virtual void RemoveFunction(Type id)
        {
            functions.Remove(id);
        }
    }
}