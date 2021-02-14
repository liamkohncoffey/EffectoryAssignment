using System.Linq;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Application.Extensions
{
    public static class BaseTypesApplicationMappingExtensions
    {
        public static QuestionApplicationResponse ToApplicationResponse(this Question question)
        {
            return new QuestionApplicationResponse
            {
                AnswerCategoryType = question.AnswerCategoryType,
                ItemType = question.ItemType,
                OrderNumber = question.OrderNumber,
                QuestionId = question.QuestionId,
                SubjectId = question.SubjectId,
                Texts = question.Texts.ToApplicationResponse(),
                Answers = question.Answers.Select(c => c.ToApplicationResponse())
            };
        }
        
        public static AnswerApplicationResponse ToApplicationResponse(this Answer answer)
        {
            return new AnswerApplicationResponse
            {
                AnswerId = answer.AnswerId,
                AnswerType = answer.AnswerType,
                ItemType = answer.ItemType,
                OrderNumber = answer.OrderNumber,
                Texts = answer.Texts.ToApplicationResponse(),
                Responses = answer.Responses?.Select(c => c.ToApplicationResponse())
            };
        }
        
        public static TextApplicationResponse ToApplicationResponse(this Text text)
        {
            return new TextApplicationResponse
            {
                Us = text.Us,
                Nl = text.Nl
            };
        }
        
        public static ResponseApplicationResponse ToApplicationResponse(this Response response)
        {
            if (response == null)
            {
                return null;
            }
            
            return new ResponseApplicationResponse
            {
                ResponseId = response.ResponseId,
                Department = response.Department,
                ItemType = response.ItemType
            };
        }
    }
}