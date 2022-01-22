using test.Debugging;

namespace test
{
    public class testConsts
    {
        public const string LocalizationSourceName = "test";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "50f4c8f304ce436dbce380c19c3fc122";
    }
}
