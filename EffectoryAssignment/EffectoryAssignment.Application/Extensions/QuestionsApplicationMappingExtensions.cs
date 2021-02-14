using System.Linq;
using EffectoryAssignment.Application.Responses.Questions;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class QuestionsApplicationMappingExtensions
    {
        public static QuestionsApplicationResponse ToQuestionsApplicationResponse(this Subject subject)
        {
            return new QuestionsApplicationResponse
            {
                Questions = subject.Questions.Select(c => c.ToApplicationResponse())
            };
        }
    }
}