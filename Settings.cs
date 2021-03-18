using ModSettings;

namespace TLDQOL_Windproof
{
    internal class windproofSettings : ModSettingsBase
    {
        [Name("Windproof Speed Multiplier")]
        [Description("Scales walking speed penalty from clothing windproof rating, in percentage per degree C")]
        [Slider(0f, 5f, 11)]
        public float windproofSpeedMultiplier = 0f;
    }
    internal static class Settings
    {
        public static windproofSettings options;
        public static void OnLoad()
        {
            options = new windproofSettings();
            options.AddToModSettings("Windproof");
        }
    }
}
