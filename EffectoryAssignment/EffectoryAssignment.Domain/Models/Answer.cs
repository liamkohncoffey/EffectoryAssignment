using System.Collections.Generic;
using Newtonsoft.Json;

namespace EffectoryAssignment.Domain.Models
{
    public class Answer : QuestionnaireItemBase
    {
        public long? AnswerId { get; set; }
        public short AnswerType { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Response> Responses { get; set; }
    }
}