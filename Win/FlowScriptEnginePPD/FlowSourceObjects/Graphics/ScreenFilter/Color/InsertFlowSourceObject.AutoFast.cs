﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.Graphics.ScreenFilter.Color
{
    public partial class InsertFlowSourceObject
    {

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "ColorFilter":
                    ColorFilter = (PPDFramework.Shaders.ColorFilterBase)value;
                    break;
                case "Filter":
                    Filter = (PPDFramework.ScreenFilters.ColorScreenFilter)value;
                    break;
                case "Index":
                    Index = (System.Int32)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Failed":
                    Failed += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Success":
                    Success += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}