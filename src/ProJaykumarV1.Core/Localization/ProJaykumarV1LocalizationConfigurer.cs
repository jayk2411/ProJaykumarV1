using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProJaykumarV1.Localization
{
    public static class ProJaykumarV1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProJaykumarV1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProJaykumarV1LocalizationConfigurer).GetAssembly(),
                        "ProJaykumarV1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
