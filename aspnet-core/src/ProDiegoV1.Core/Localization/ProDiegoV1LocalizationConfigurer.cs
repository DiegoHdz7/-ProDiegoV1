using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProDiegoV1.Localization
{
    public static class ProDiegoV1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProDiegoV1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProDiegoV1LocalizationConfigurer).GetAssembly(),
                        "ProDiegoV1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
