using System.Linq;
using EffectoryAssignment.Application.Responses.Questions;
using EffectoryAssignment.Definition.Responses.Questions;

namespace EffectoryAssignment.API.Extensions
{
    public static class QuestionsMappingExtensions
    {
        public static GetQuestionsResponse ToApiResponse(this QuestionsApplicationResponse response)
        {
            return new GetQuestionsResponse
            {
                Questions = response.Questions.Select(c => c.ToApiResponse())
            };
        }
    }
}