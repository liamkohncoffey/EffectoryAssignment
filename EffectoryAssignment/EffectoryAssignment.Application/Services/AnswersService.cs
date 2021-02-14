using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Extensions;
using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Application.Responses.Answers;
using EffectoryAssignment.Domain.Repositories;

namespace EffectoryAssignment.Application.Services
{
    public class AnswersService : IAnswersService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public AnswersService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<AnswersApplicationResponse> GetAnswers(long subjectId, long questionId, CancellationToken cancellationToken = default)
        {
            var answers = await _questionnaireRepository.GetAnswers(subjectId, questionId, cancellationToken);

            return answers.ToApplicationResponse();
        }

        public async Task<AnswerApplicationResponse> GetAnswer(long subjectId, long questionId, long answerId, CancellationToken cancellationToken)
        {
            var answer = await _questionnaireRepository.GetAnswer(subjectId, questionId, answerId, cancellationToken);

            return answer.ToApplicationResponse();
        }
    }
}