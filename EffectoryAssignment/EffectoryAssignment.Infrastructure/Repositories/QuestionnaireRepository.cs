using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.Domain.Models;
using EffectoryAssignment.Domain.Repositories;
using Newtonsoft.Json;

namespace EffectoryAssignment.Infrastructure.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private static Questionnaire _questionnaire;

        public QuestionnaireRepository()
        {
            var json = File.ReadAllText("../EffectoryAssignment.Infrastructure/questionnaire.json");
            _questionnaire = JsonConvert.DeserializeObject<Questionnaire>(json);
        }
        
        public async Task<Subject> GetQuestionnaireItem(long subjectId, long questionId, CancellationToken cancellationToken = default)
        {
            var questionnaireItem = _questionnaire.Subjects.FirstOrDefault(c => c.SubjectId == subjectId);

            if(questionnaireItem == null)
            {
                return new Subject();
            }

            return questionnaireItem;
        }
    }
}