using System.Linq;
using EffectoryAssignment.Application.Requests.questions;
using EffectoryAssignment.Definition.Requests.Questions;

namespace EffectoryAssignment.API.Extensions
{
    public static class QuestionsMappingExtensions
    {
        public static GetQuestionsResponse ToApiResponse(this QuestionsApplicationResponse response)
        {
            return new GetQuestionsResponse
            {
                Questions = response.Questions.Select(c => c.ToQuestionResponse())
            };
        }
    }
}