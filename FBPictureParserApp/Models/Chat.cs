using Newtonsoft.Json;

namespace FBPictureParserApp.Models
{
    public class Chat {
        public string Title { get; set; }
        public Image Image { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Message> Messages { get; set; }
    }

}
