using System.Collections.Generic;

namespace EffectoryAssignment.Definition.Requests.Questions
{
    public class GetQuestionsResponse
    {
        public IEnumerable<QuestionResponse> Questions { get; set; } 
    }
}