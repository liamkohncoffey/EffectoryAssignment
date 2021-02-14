using System.Collections.Generic;

namespace EffectoryAssignment.Application.Requests.questions
{
    public class QuestionsApplicationResponse
    {
        public IEnumerable<QuestionApplicationResponse> Questions { get; set; } 
    }
}