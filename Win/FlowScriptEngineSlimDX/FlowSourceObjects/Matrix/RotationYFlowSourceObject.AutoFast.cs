﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Matrix
{
    public partial class RotationYFlowSourceObject
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
                case "Angle":
                    Angle = (System.Single)value;
                    break;
            }
        }

    }
}
