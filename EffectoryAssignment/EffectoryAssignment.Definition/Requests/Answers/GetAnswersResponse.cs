using System.Collections.Generic;

namespace EffectoryAssignment.Definition.Requests.Answers
{
    public class GetAnswersResponse
    {
        public IEnumerable<AnswerResponse> Answers { get; set; } 
    }
}