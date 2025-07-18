using System.Text.Json;

namespace Unit3Demo.Utils
{
    internal static class JsonUtils
    {
        public static string ReadStringByKey(string json, string key)
        {
            using var doc = JsonDocument.Parse(json);
            string value = doc.RootElement.GetProperty(key).GetString()!;
            return value;
        }

        public static string ReadStringByKeyFromFile(string filePath, string key)
        {
            string json = File.ReadAllText(filePath);
            return ReadStringByKey(json, key);
        }
    }
}
