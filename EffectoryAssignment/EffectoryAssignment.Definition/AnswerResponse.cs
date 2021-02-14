using System.Collections.Generic;

namespace EffectoryAssignment.Definition
{
    public class AnswerResponse : QuestionnaireItemBaseResponse
    {
        public long? AnswerId { get; set; }
        public short AnswerType { get; set; }
        public IEnumerable<ResponseResponse> Responses { get; set; }
    }
}