using ReGrowthCore;
using Verse;

namespace BetterRegrowthBoulderNames
{
    public class CompProperties_BoulderWithOreLabel : CompProperties
    {
        public CompProperties_BoulderWithOreLabel()
        {
            compClass = typeof(BoulderWithOreLabelComp);
        }
    }

    public class BoulderWithOreLabelComp : ThingComp
    {
        private CompContainsOre OreComp =>
            parent.TryGetComp<CompContainsOre>();

        public override string TransformLabel(string label)
        {
            return OreComp?.chosenOreDef == null ? label : $"{label} ({OreComp.chosenOreDef.label})";
        }
    }
}