using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Application.Extensions;
using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Application.Responses.Questions;
using EffectoryAssignment.Domain.Repositories;

namespace EffectoryAssignment.Application.Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public QuestionsService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<QuestionsApplicationResponse> GetQuestions(long subjectId,  CancellationToken cancellationToken = default)
        {
            var subject = await _questionnaireRepository.GetSubject(subjectId, cancellationToken);

            return subject.ToQuestionsApplicationResponse();
        }

        public async Task<QuestionApplicationResponse> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken)
        {
            var subject = await _questionnaireRepository.GetQuestion(subjectId, questionId, cancellationToken);

            return subject.ToApplicationResponse();
        }
    }
}