using System.Collections.Generic;

namespace EffectoryAssignment.Definition
{
    public class QuestionResponse : QuestionnaireItemBaseResponse
    {
        public long? QuestionId { get; set; }
        public long? SubjectId { get; set; }
        public short AnswerCategoryType { get; set; }
        public IEnumerable<AnswerResponse> Answers { get; set; }
    }
}