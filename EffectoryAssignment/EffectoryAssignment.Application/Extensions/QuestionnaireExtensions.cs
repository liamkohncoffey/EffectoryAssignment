using EffectoryAssignment.Application.Requests.questions;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class QuestionnaireExtensions
    {
        public static GetQuestionnaireItemApplicationResponse ToQuestionnaireItemApplicationResponse(this Subject questionnaireItem)
        {
            return new GetQuestionnaireItemApplicationResponse
            {
                QuestionId = questionnaireItem.SubjectId
            };
        }
    }
}