using EffectoryAssignment.Application.Requests.questions;
using EffectoryAssignment.Domain.Requests.Questions;

namespace EffectoryAssignment.API.Extensions
{
    public static class MappingExtensions
    {
        public static GetQuestionsResponse ToApiResponse(this GetQuestionnaireItemApplicationResponse response)
        {
            return new GetQuestionsResponse
            {
            };
        }
    }
}