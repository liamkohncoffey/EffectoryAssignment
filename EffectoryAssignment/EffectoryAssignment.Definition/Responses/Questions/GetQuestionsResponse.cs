using System.Collections.Generic;

namespace EffectoryAssignment.Definition.Responses.Questions
{
    public class GetQuestionsResponse
    {
        public IEnumerable<QuestionResponse> Questions { get; set; } 
    }
}