﻿using FlowScriptEngine;

namespace FlowScriptEngineBasic.FlowSourceObjects.Math
{
    [ToolTipText("Math_Sign_Summary", "Math_Sign_Remark")]
    public partial class SignInt32FlowSourceObject : FlowSourceObjectBase
    {
        public override string Name
        {
            get { return "Math.Sign"; }
        }

        [ToolTipText("Math_Sign_A")]
        public int A
        {
            private get;
            set;
        }

        [ToolTipText("Math_Sign_Value")]
        public int Value
        {
            get
            {
                SetValue(nameof(A));
                return System.Math.Sign(A);
            }
        }
    }
}
