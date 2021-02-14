using Newtonsoft.Json;

namespace EffectoryAssignment.Domain.Models
{
    public class Text
    {
        [JsonProperty("nl-NL")]
        public string Nl { get; set; }
        [JsonProperty("en-US")]
        public string Us { get; set; }
    }
}