﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Matrix
{
    public partial class EqualFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Value":
                    return Value;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "A":
                    A = (SharpDX.Matrix)value;
                    break;
                case "B":
                    B = (SharpDX.Matrix)value;
                    break;
            }
        }

    }
}