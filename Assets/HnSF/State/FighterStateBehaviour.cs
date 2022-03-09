using UnityEngine;
using UnityEngine.Playables;

namespace HnSF
{
    [System.Serializable]
    public class FighterStateBehaviour : PlayableBehaviour
    {
        [SelectImplementation(typeof(StateConditionBase))] [SerializeField, SerializeReference]
        public StateConditionBase conditon = new StateConditionBoolean();
    }
}