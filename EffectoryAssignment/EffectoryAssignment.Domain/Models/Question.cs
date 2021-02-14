using System.Collections.Generic;
using Newtonsoft.Json;

namespace EffectoryAssignment.Domain.Models
{
    public class Question : QuestionnaireItemBase
    {
        public long? QuestionId { get; set; }
        public long? SubjectId { get; set; }
        public short AnswerCategoryType { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Answer> Answers { get; set; }
    }
}