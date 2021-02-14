using System.Collections.Generic;

namespace EffectoryAssignment.Definition.Responses.Answers
{
    public class GetAnswersResponse
    {
        public IEnumerable<AnswerResponse> Answers { get; set; } 
    }
}