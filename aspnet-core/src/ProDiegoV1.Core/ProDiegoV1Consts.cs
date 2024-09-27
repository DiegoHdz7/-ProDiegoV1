using ProDiegoV1.Debugging;

namespace ProDiegoV1
{
    public class ProDiegoV1Consts
    {
        public const string LocalizationSourceName = "ProDiegoV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "906331ffc4af44d096ec8ade53cb35d8";
    }
}
