using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Requests.Answers;

namespace EffectoryAssignment.Application.Interfaces
{
    public interface IResponseService
    {
        Task<bool> AddResponse(PostAnswerApplicationRequest request, CancellationToken cancellationToken);
    }
}