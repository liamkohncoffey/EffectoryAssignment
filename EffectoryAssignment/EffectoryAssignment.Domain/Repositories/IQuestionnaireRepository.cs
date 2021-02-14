using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Domain.Models;

namespace EffectoryAssignment.Domain.Repositories
{
    public interface IQuestionnaireRepository
    {
        Task<Subject> GetSubject(long subjectId, CancellationToken cancellationToken = default);
        Task<Question> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken  = default);
        Task<IEnumerable<Answer>> GetAnswers(long subjectId, long questionId, CancellationToken cancellationToken = default);
        Task<Answer> GetAnswer(long subjectId, long questionId, long answerId, CancellationToken cancellationToken = default);
        Task<bool> AddResponse(long subjectId, long questionId, long answerId, Response response, CancellationToken cancellationToken = default);
    }
}