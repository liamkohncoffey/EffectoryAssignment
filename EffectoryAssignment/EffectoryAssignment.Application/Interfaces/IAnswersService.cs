using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Application.Responses.Answers;

namespace EffectoryAssignment.Application.Interfaces
{
    public interface IAnswersService
    {
        Task<AnswersApplicationResponse> GetAnswers(long subjectId, long questionId,  CancellationToken cancellationToken = default);
        Task<AnswerApplicationResponse> GetAnswer(long subjectId, long questionId, long answerId, CancellationToken cancellationToken);
    }
}