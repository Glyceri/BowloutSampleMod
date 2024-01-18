using BowloutModManager.BowloutMod.Interfaces;
using UnityEngine;

namespace BowloutSampleMod
{
    public class SampleModConfiguration : IBowloutConfiguration
    {
        public int Version { get => 1; set => _ = value; }

        public bool IAmABoolConfig;

        // The range attribute is MANDATORY
        [Range(0, 10)]
        public float IAmAFloatConfig;

        // The range attribute is MANDATORY
        [Range(0, 10)]
        public int IAmAIntConfig;
    }
}
