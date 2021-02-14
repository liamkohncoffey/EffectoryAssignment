using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Domain.Models;
using EffectoryAssignment.Domain.Repositories;

namespace EffectoryAssignment.Infrastructure.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        public static Questionnaire Questionnaire;

        public QuestionnaireRepository(Questionnaire questionnaire)
        {
            Questionnaire = questionnaire;
        }
        
        public async Task<Subject> GetSubject(long subjectId, CancellationToken cancellationToken = default)
        {
            var subject = Questionnaire.Subjects.FirstOrDefault(c => c.SubjectId == subjectId);

            if(subject == null)
            {
                return new Subject();
            }

            return subject;
        }

        public async Task<Question> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken)
        {
            var question = Questionnaire.Subjects.FirstOrDefault(c => c.SubjectId == subjectId)?.Questions
                .FirstOrDefault(c => c.QuestionId.HasValue && c.QuestionId.Value == questionId);

            if (question == null)
            {
                return new Question();
            }

            return question;
        }
    }
}