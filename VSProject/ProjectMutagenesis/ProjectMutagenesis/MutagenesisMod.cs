// MutagenesisMod.cs created by Iron Wolf for ProjectMutagenesis on 05/30/2021 5:55 PM
// last updated 05/30/2021  5:55 PM

using System;
using HarmonyLib;
using UnityEngine;

namespace ProjectMutagenesis
{
    public class MutagenesisMod : HospitalMod
    {
        /// <summary>
        /// short symbol for the mod
        /// </summary>
        public const string MUTAGENESIS_SYMBOL = "MUT";

        /// <summary>
        /// full title of the mod 
        /// </summary>
        public const string MUTAGENESIS_NAME = "Project Mutagenesis";

        public const string HARMONY_ID = "YaffIW.Mutagenesis";

        private void Awake()
        {
            //TODO mod init 

            try
            {
                HarmonyPatch();
            }
            catch (Exception e)
            {
                Debug.LogError($"encountered {e.GetType().FullName} while patching! \n{e}");
            }

        }


        void HarmonyPatch()
        {
            var har = new Harmony(HARMONY_ID);


            har.PatchAll();


        }

    }
}