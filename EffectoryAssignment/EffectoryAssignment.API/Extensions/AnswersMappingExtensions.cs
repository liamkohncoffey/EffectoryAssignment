using System.Linq;
using EffectoryAssignment.Application.Requests.Answers;
using EffectoryAssignment.Definition.Requests.Answers;

namespace EffectoryAssignment.API.Extensions
{
    public static class AnswersMappingExtensions
    {
        public static GetAnswersResponse ToApiResponse(this AnswersApplicationResponse response)
        {
            return new GetAnswersResponse
            {
                Answers = response.Answers.Select(c => c.ToAnswerResponse())
            };
        }
    }
}