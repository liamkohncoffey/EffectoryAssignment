using System.Collections.Generic;

namespace EffectoryAssignment.Application.Responses
{
    public class AnswerApplicationResponse : QuestionnaireItemBaseApplicationResponse
    {
        public long? AnswerId { get; set; }
        public short AnswerType { get; set; }
        public IEnumerable<ResponseApplicationResponse> Responses { get; set; }
    }
}