using BowloutModManager.BowloutMod;
using BowloutModManager.BowloutMod.Interfaces;
using System;

namespace BowloutSampleMod
{
    public class BowloutSampleMod : IBowloutMod
    {
        public string Name => "Bowlout Sample Mod";

        public Version Version => new Version(1, 0, 0, 0);

        public string Description => "A sample mod for Bowlout.";

        public IBowloutConfiguration Configuration { get; private set; }
        public SampleModConfiguration SampleModConfiguration => (SampleModConfiguration)Configuration;

        public void OnSetup()
        {
            Configuration = this.GetConfiguration<SampleModConfiguration>() ?? new SampleModConfiguration();
        }

        public void Dispose()
        {
            
        }

        public void OnEnable()
        {

        }

        public void OnDisable()
        {
            
        }

        public void OnUpdate()
        {

        }

        public void OnFixedUpdate()
        {
            
        }

        public void OnLateUpdate()
        {
            
        }
    }
}
