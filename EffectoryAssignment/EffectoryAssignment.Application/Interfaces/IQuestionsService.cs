using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Application.Responses.Questions;

namespace EffectoryAssignment.Application.Interfaces
{
    public interface IQuestionsService
    {
        Task<QuestionsApplicationResponse> GetQuestions(long subjectId, CancellationToken cancellationToken = default);
        Task<QuestionApplicationResponse> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken);
    }
}