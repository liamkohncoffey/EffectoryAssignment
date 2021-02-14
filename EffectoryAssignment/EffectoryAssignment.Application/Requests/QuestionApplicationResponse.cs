using System.Collections.Generic;

namespace EffectoryAssignment.Application.Requests
{
    public class QuestionApplicationResponse : QuestionnaireItemBaseApplicationResponse
    {
        public long? QuestionId { get; set; }
        public long? SubjectId { get; set; }
        public short AnswerCategoryType { get; set; }
        public IEnumerable<AnswerApplicationResponse> Answers { get; set; }
    }
}