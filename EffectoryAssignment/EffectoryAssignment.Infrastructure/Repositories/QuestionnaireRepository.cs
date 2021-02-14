using System.Collections.Generic;
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

        public async Task<Answer> GetAnswer(long subjectId, long questionId, long answerId, CancellationToken cancellationToken)
        {
            var answers = Questionnaire.Subjects.FirstOrDefault(c => c.SubjectId == subjectId)?
                .Questions.FirstOrDefault(c => c.QuestionId.HasValue && c.QuestionId.Value == questionId)?
                .Answers.FirstOrDefault(c => c.AnswerId.HasValue &&  c.AnswerId.Value == answerId);

            if (answers == null)
            {
                return new Answer();
            }

            return answers;
        }

        public async Task<IEnumerable<Answer>> GetAnswers(long subjectId, long questionId, CancellationToken cancellationToken)
        {
            var answers = Questionnaire.Subjects
                .FirstOrDefault(c => c.SubjectId == subjectId)?
                .Questions.FirstOrDefault(c => c.QuestionId.HasValue && c.QuestionId.Value == questionId)?
                .Answers;

            if (answers == null)
            {
                return new List<Answer>();
            }

            return answers;
        }
    }
}