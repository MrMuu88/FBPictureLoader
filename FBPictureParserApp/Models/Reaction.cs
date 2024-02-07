using Newtonsoft.Json;

namespace FBPictureParserApp.Models
{
    public class Reaction
    {
        [JsonProperty("reaction")]
        public string ReactionType { get; set; }
        public string actor { get; set; }
    }
}
