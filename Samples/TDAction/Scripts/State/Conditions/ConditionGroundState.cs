namespace HnSF.Sample.TDAction.State
{
    public struct ConditionGroundState : IConditionVariables
    {
        public int FunctionMap => (int)ConditionFunctionEnum.GROUND_STATE;
        
        public bool inverse;
    }
}