using Newtonsoft.Json;

namespace FBPictureParserApp.Models
{
    public class Message {
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
        [JsonProperty("timestamp_ms")]
        [JsonConverter(typeof(EpocDateTimeConverter))]
        public DateTime TimeStamp { get; set; }

        public List<Image> Videos { get; set; } = new List<Image>();
        public List<Image> Photos { get; set; } = new List<Image>();

        public List<Reaction> reactions { get; set; } = new List<Reaction>();
    }
}
