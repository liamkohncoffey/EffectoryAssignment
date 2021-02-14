using System.Linq;
using EffectoryAssignment.Application.Requests;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class BaseTypesApplicationMappingExtensions
    {
        public static QuestionApplicationResponse ToQuestionApplicationResponse(this Question question)
        {
            return new QuestionApplicationResponse
            {
                AnswerCategoryType = question.AnswerCategoryType,
                ItemType = question.ItemType,
                OrderNumber = question.OrderNumber,
                QuestionId = question.QuestionId,
                SubjectId = question.SubjectId,
                Texts = question.Texts.ToTextApplicationResponse(),
                Answers = question.Answers.Select(c => c.ToAnswerApplicationResponse())
            };
        }
        
        public static AnswerApplicationResponse ToAnswerApplicationResponse(this Answer answer)
        {
            return new AnswerApplicationResponse
            {
                AnswerId = answer.AnswerId,
                AnswerType = answer.AnswerType,
                ItemType = answer.ItemType,
                OrderNumber = answer.OrderNumber,
                Texts = answer.Texts.ToTextApplicationResponse()
            };
        }
        
        public static TextApplicationResponse ToTextApplicationResponse(this Text text)
        {
            return new TextApplicationResponse
            {
                Us = text.Us,
                Nl = text.Nl
            };
        }
    }
}