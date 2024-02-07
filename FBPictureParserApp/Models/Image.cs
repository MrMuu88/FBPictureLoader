using Newtonsoft.Json;

namespace FBPictureParserApp.Models
{
    public class Image
    {
        public string Uri { get; set; }
        [JsonProperty("creation_timestamp")]
        [JsonConverter(typeof(EpocDateTimeConverter))]
        public DateTime CreationTimeStamp { get; set; }
    }

}
