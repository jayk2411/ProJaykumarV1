using ProJaykumarV1.Debugging;

namespace ProJaykumarV1
{
    public class ProJaykumarV1Consts
    {
        public const string LocalizationSourceName = "ProJaykumarV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "bb59c50df5924e5d9724056f48eed56d";
    }
}
