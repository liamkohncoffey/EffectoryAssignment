using System.Collections.Generic;
using Newtonsoft.Json;

namespace EffectoryAssignment.Domain.Models
{
    public class Subject : QuestionnaireItemBase
    {
        public long? SubjectId { get; set; }
        public short AnswerCategoryType { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Question> Questions { get; set; }
    }
}