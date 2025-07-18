using System.Text.Json;

namespace Unit3Demo.Utils.Config
{
    internal static class ConfigFileReader
    {
        public const string ResourcesPath = "Resources/";
        public const string EnvironmentPath = ResourcesPath + "Environment/";
        public const string TestRunSettingsFilePath = ResourcesPath + "testRunSettings.json";
        public const string EnvKey = "env";
        private static EnvironmentData? _cachedEnvData;

        private static string GetCurrentEnvironmentPath() => JsonUtils.ReadStringByKeyFromFile(TestRunSettingsFilePath, EnvKey) + ".json";

        public static EnvironmentData GetEnvironmentData()
        {
            if (_cachedEnvData is null)
            {
                string json = File.ReadAllText(EnvironmentPath + GetCurrentEnvironmentPath());
                _cachedEnvData = JsonSerializer.Deserialize<EnvironmentData>(json)!;
            }
            return _cachedEnvData;
        }
    }
}