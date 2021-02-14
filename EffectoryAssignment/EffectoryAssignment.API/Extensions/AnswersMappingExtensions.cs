using System;
using System.Linq;
using EffectoryAssignment.Application.Requests.Answers;
using EffectoryAssignment.Application.Responses.Answers;
using EffectoryAssignment.Definition.Requests;
using EffectoryAssignment.Definition.Responses.Answers;
using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.API.Extensions
{
    public static class AnswersMappingExtensions
    {
        public static GetAnswersResponse ToApiResponse(this AnswersApplicationResponse response)
        {
            return new GetAnswersResponse
            {
                Answers = response.Answers.Select(c => c.ToApiResponse())
            };
        }

        public static PostAnswerApplicationRequest ToApplicationRequest(this PostResponseRequest request, long subjectId, long questionsId, long answersId)
        {
            return new PostAnswerApplicationRequest
            {
                Department = Enum.TryParse<Departments>(request.Department, out var department) ? department : Departments.Unknown,
                SubjectId = subjectId,
                QuestionId = questionsId,
                AnswersId = answersId
            };
        }
    }
}