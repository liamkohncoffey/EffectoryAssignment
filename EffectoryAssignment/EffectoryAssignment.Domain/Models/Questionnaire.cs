using System.Collections.Generic;
using System.Text.Json;
using EffectoryAssignment.SharedKernel.Enums;
using Newtonsoft.Json;

namespace EffectoryAssignment.Domain.Models
{
    public class Questionnaire
    {
        public int QuestionnaireId { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Subject> Subjects { get; set; }
    }

    public class QuestionnaireItemBase
    {
        public ItemType ItemType { get; set; }
        public Text Texts { get; set; }
        public int OrderNumber { get; set; }
    }
    
    public class Subject : QuestionnaireItemBase
    {
        public long? SubjectId { get; set; }
        public short AnswerCategoryType { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Question> Questions { get; set; }
    }
    
    public class Question : QuestionnaireItemBase
    {
        public long? QuestionId { get; set; }
        public long? SubjectId { get; set; }
        public short AnswerCategoryType { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<Answer> Answers { get; set; }
    }
    
    public class Answer : QuestionnaireItemBase
    {
        public long? AnswerId { get; set; }
        public short AnswerType { get; set; }
        [JsonProperty("QuestionnaireItems")]
        public List<QuestionnaireItemBase> QuestionnaireItems { get; set; }
    }
    
    public class Text
    {
        [JsonProperty("nl-NL")]
        public string NlNl { get; set; }
        [JsonProperty("en-US")]
        public string EnUs { get; set; }
    }
}