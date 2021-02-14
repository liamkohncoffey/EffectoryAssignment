using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Domain.Repositories
{
    public interface IQuestionnaireRepository
    {
        Task<Subject> GetQuestionnaireItem(long subjectId, long questionId, CancellationToken cancellationToken = default);
    }
}