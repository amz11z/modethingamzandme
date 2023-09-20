using OWML.Common;
using OWML.ModHelper;

namespace ArabicTranslation
{
	public class ArabicTranslation : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"{nameof(ArabicTranslation)} is loaded!", MessageType.Success);

            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "Arabic", "assets/Translation.xml");
            api.AddLanguageFont(this, "Arabic", "assets/b_mitra_0", "Assets/B_MITRA_0.TTF");
            api.AddLanguageFixer("Arabic", ArabicSupport.OuterWildsArabic.Fix);
        }
    }
}
