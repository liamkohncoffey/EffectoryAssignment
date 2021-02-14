using System.Collections.Generic;

namespace EffectoryAssignment.Application.Requests.Answers
{
    public class AnswersApplicationResponse
    {
        public IEnumerable<AnswerApplicationResponse> Answers { get; set; } 
    }
}