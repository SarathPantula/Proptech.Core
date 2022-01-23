using Newtonsoft.Json;

namespace Proptech.Core.Converters
{
    public class ProptechDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString("yyyy'-'MMM'-'dd'T'HH':'mm"));
        }
    }
}
