using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Application.Requests.Answers;
using EffectoryAssignment.Domain.Models;
using EffectoryAssignment.Domain.Repositories;

namespace EffectoryAssignment.Application.Services
{
    public class ResponseService : IResponseService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public ResponseService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<bool> AddResponse(PostAnswerApplicationRequest request, CancellationToken cancellationToken)
        {
            var saved = await _questionnaireRepository.AddResponse(request.SubjectId, request.QuestionId, request.AnswersId,
                new Response(request.Department), cancellationToken);

            return saved;
        }
    }
}