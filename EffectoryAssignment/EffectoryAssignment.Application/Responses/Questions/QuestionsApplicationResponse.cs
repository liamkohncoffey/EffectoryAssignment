using System.Collections.Generic;

namespace EffectoryAssignment.Application.Responses.Questions
{
    public class QuestionsApplicationResponse
    {
        public IEnumerable<QuestionApplicationResponse> Questions { get; set; } 
    }
}