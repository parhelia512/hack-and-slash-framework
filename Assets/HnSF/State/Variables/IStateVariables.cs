using UnityEngine;

namespace HnSF
{
    public interface IStateVariables
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Parent { get; set; }
        public int[] Children { get; set; }


        public Vector2Int[] FrameRanges { get; set; }
        public IConditionVariables Condition { get; set; }

        IStateVariables Copy();
    }
}