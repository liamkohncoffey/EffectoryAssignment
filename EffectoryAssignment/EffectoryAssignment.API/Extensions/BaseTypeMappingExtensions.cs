using System.Linq;
using EffectoryAssignment.Application.Requests;
using EffectoryAssignment.Definition;

namespace EffectoryAssignment.API.Extensions
{
    public static class BaseTypeMappingExtensions
    {
        public static QuestionResponse ToQuestionResponse(this QuestionApplicationResponse question)
        {
            return new QuestionResponse
            {
                AnswerCategoryType = question.AnswerCategoryType,
                SubjectId = question.SubjectId,
                ItemType = question.ItemType,
                OrderNumber = question.OrderNumber,
                QuestionId = question.QuestionId,
                Texts = question.Texts.ToTextResponse(),
                Answers = question.Answers.Select(c => c.ToAnswerResponse())
            };
        }
        
        public static AnswerResponse ToAnswerResponse(this AnswerApplicationResponse answer)
        {
            return new AnswerResponse
            {
                AnswerId = answer.AnswerId,
                AnswerType = answer.AnswerType,
                ItemType = answer.ItemType,
                OrderNumber = answer.OrderNumber,
                Texts = answer.Texts.ToTextResponse()
            };
        }
        
        public static TextResponse ToTextResponse(this TextApplicationResponse text)
        {
            return new TextResponse
            {
                Us = text.Us,
                Nl = text.Nl
            };
        }
    }
}