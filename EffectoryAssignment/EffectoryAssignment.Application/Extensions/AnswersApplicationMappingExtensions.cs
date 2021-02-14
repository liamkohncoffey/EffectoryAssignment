using System.Collections.Generic;
using System.Linq;
using EffectoryAssignment.Application.Requests.Answers;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class AnswersApplicationMappingExtensions
    {
        public static AnswersApplicationResponse ToAnswersApplicationResponse(this IEnumerable<Answer> answers)
        {
            return new AnswersApplicationResponse
            {
                Answers = answers.Select(c => c.ToAnswerApplicationResponse())
            };
        }
    }
}