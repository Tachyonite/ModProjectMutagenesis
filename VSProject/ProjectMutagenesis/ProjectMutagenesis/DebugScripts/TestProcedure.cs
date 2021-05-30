// TestProcedure.cs created by Iron Wolf for ProjectMutagenesis on 05/30/2021 10:20 AM
// last updated 05/30/2021  10:20 AM

using Lopital;
using UnityEngine;

namespace ProjectMutagenesis.DebugScripts
{
    public class TestProcedure : ProcedureScript
    {
        public override void Activate()
        {
            base.Activate();
            LogUtils.LogMessage("Test procedure ");
            //can just add symptoms here? 
        }

        public override bool IsIdle()
        {
            return true; 
        }
    }
}