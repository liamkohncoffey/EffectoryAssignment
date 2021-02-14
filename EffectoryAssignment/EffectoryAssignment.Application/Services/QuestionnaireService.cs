using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Extensions;
using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Application.Requests.questions;
using EffectoryAssignment.Domain.Repositories;

namespace EffectoryAssignment.Application.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public QuestionnaireService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<GetQuestionnaireItemApplicationResponse> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken = default)
        {
            var response = await _questionnaireRepository.GetQuestionnaireItem(subjectId, questionId, cancellationToken);

            return response.ToQuestionnaireItemApplicationResponse();
        }
    }
}