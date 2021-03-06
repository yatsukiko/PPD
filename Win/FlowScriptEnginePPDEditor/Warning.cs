﻿using FlowScriptEngine;

namespace FlowScriptEnginePPDEditor
{
    public class Warning : IWarning
    {
        private string key;
        private string text;
        public Warning(string key)
        {
            this.key = key;
            this.text = FlowScriptEnginePPDEditor.Properties.Resources.ResourceManager.GetString(key);
        }

        public override string TextKey
        {
            get { return key; }
        }

        public override string Text
        {
            get { return text; }
        }
    }
}
