﻿using FlowScriptEngine;

namespace FlowScriptEngineBasic
{
    public class ToolTipText : IToolTipText
    {
        private string toolTipText;
        private string summary;
        private string remark;
        private string key;

        public ToolTipText(string summary)
        {
            this.key = summary;
            this.summary = FlowScriptEngineBasic.Properties.Resources.ResourceManager.GetString(summary);
            toolTipText = this.summary;
        }

        public ToolTipText(string summary, string remark)
        {
            this.key = summary;
            this.summary = FlowScriptEngineBasic.Properties.Resources.ResourceManager.GetString(summary);
            this.remark = FlowScriptEngineBasic.Properties.Resources.ResourceManager.GetString(remark);
            toolTipText = this.summary + "\n" + this.remark;
        }

        public override string Text
        {
            get
            {
                return toolTipText;
            }
        }

        public override string Summary
        {
            get { return summary; }
        }

        public override string TextKey
        {
            get { return key; }
        }
    }
}
