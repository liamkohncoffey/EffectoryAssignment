using System.Linq;
using EffectoryAssignment.Application.Requests.questions;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class QuestionsApplicationMappingExtensions
    {
        public static QuestionsApplicationResponse ToQuestionsApplicationResponse(this Subject subject)
        {
            return new QuestionsApplicationResponse
            {
                Questions = subject.Questions.Select(c => c.ToQuestionApplicationResponse())
            };
        }
    }
}