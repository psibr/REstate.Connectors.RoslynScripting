﻿using Psibr.Platform.Logging;

namespace REstate.Connectors.RoslynScripting.Globals
{
    public class RoslynScriptGlobals
    {
        public string CurrentState =>
            Machine.GetCurrentState().StateName;

        public IStateMachine Machine { get; set; }

        public IPlatformLogger Logger { get; set; }

        public string Payload { get; set; }
    }
}