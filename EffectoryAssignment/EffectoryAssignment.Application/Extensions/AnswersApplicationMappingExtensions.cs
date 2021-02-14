using System.Collections.Generic;
using System.Linq;
using EffectoryAssignment.Application.Responses.Answers;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class AnswersApplicationMappingExtensions
    {
        public static AnswersApplicationResponse ToApplicationResponse(this IEnumerable<Answer> answers)
        {
            return new AnswersApplicationResponse
            {
                Answers = answers.Select(c => c.ToApplicationResponse())
            };
        }
    }
}