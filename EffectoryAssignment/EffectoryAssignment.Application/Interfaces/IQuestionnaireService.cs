using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Requests.questions;

namespace EffectoryAssignment.Application.Interfaces
{
    public interface IQuestionnaireService
    {
        Task<GetQuestionnaireItemApplicationResponse> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken = default);
    }
}