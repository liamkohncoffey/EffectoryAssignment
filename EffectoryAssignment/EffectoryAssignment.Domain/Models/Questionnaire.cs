using System.Collections.Generic;
using Newtonsoft.Json;

namespace EffectoryAssignment.Domain.Models
{
    public class Questionnaire
    {
        public int QuestionnaireId { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Subject> Subjects { get; set; }
    }
}