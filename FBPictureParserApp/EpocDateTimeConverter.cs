using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Diagnostics;

namespace FBPictureParserApp
{
    public class EpocDateTimeConverter : DateTimeConverterBase
    {
        private DateTime epoc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if(reader.Value == null) return null;

            long value = (long)reader.Value;
            if (reader.Value.ToString().Length == 10)
                value = value * 1000;

            DateTime converted = epoc.AddMilliseconds(value);
            return converted;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            string strval = ((DateTime)value - epoc).TotalMilliseconds + "";
            writer.WriteRawValue(strval);
        }
    }
}
