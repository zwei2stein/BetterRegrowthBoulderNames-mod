using Verse;

namespace BetterRegrowthBoulderNames
{
    
    [StaticConstructorOnStartup]
    public static class BetterRegrowthBoulderNamesModInit
    {
        static BetterRegrowthBoulderNamesModInit()
        {
            if (Prefs.DevMode)
            {
                Log.Message("[BetterRegrowthBoulderNames] Loaded.");
            }
        }
    }
    
}