using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Requests;
using EffectoryAssignment.Application.Requests.questions;

namespace EffectoryAssignment.Application.Interfaces
{
    public interface IQuestionsService
    {
        Task<QuestionsApplicationResponse> GetQuestions(long subjectId, CancellationToken cancellationToken = default);
        Task<QuestionApplicationResponse> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken);
    }
}