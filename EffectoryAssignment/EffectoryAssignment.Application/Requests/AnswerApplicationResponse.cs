using System.Collections.Generic;

namespace EffectoryAssignment.Application.Requests
{
    public class AnswerApplicationResponse : QuestionnaireItemBaseApplicationResponse
    {
        public long? AnswerId { get; set; }
        public short AnswerType { get; set; }
        public List<QuestionnaireItemBaseApplicationResponse> QuestionnaireItems { get; set; }
    }
}