// LogUtils.cs created by Iron Wolf for ProjectMutagenesis on 05/30/2021 10:22 AM
// last updated 05/30/2021  10:22 AM

using System.Text;
using JetBrains.Annotations;
using UnityEngine;

namespace ProjectMutagenesis.DebugScripts
{
    public static class LogUtils
    {
        

        public static void LogMessage(string message)
        {
            Debug.Log(MutagenesisInit.MUTAGENESIS_SYMBOL + ":" + message);
        }


        public static void LogMessage([NotNull] StringBuilder builder)
        {
            LogMessage(builder.ToString()); 
        }
    }
}