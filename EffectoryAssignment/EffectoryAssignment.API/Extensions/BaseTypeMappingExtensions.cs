using System.Linq;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Definition;
using ResponseResponse = EffectoryAssignment.Definition.ResponseResponse;

namespace EffectoryAssignment.API.Extensions
{
    public static class BaseTypeMappingExtensions
    {
        public static QuestionResponse ToApiResponse(this QuestionApplicationResponse question)
        {
            return new QuestionResponse
            {
                AnswerCategoryType = question.AnswerCategoryType,
                SubjectId = question.SubjectId,
                ItemType = question.ItemType,
                OrderNumber = question.OrderNumber,
                QuestionId = question.QuestionId,
                Texts = question.Texts.ToApiResponse(),
                Answers = question.Answers.Select(c => c.ToApiResponse())
            };
        }
        
        public static AnswerResponse ToApiResponse(this AnswerApplicationResponse answer)
        {
            return new AnswerResponse
            {
                AnswerId = answer.AnswerId,
                AnswerType = answer.AnswerType,
                ItemType = answer.ItemType,
                OrderNumber = answer.OrderNumber,
                Texts = answer.Texts.ToApiResponse(),
                Responses = answer.Responses?.Select(c => c.ToResponseResponse())
            };
        }
        
        public static TextResponse ToApiResponse(this TextApplicationResponse text)
        {
            return new TextResponse
            {
                Us = text.Us,
                Nl = text.Nl
            };
        }
        
        public static ResponseResponse ToResponseResponse(this ResponseApplicationResponse response)
        {
            if (response == null)
            {
                return null;
            }
            
            return new ResponseResponse
            {
                ResponseId = response.ResponseId,
                Department = response.Department,
                ItemType = response.ItemType
            };
        }
    }
}